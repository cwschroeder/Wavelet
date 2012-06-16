namespace Wavelet.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;

    public enum MatrixType
    {
        Transformed,
        Retransformed
    }


    /// <summary>
    /// Container for rows.
    /// </summary>
    public class DataMatrix
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataMatrix"/> class.
        /// </summary>
        public DataMatrix(MatrixType type, int columnCount)
        {
            this.Type = type;
            this.ColumnCount = columnCount;
            this.Rows = new List<DataRow>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMatrix"/> class.
        /// </summary>
        /// <param name="asciiFilePath">The file path to an UNTRANSFORMED matrix in ASCII format.</param>
        public DataMatrix(string asciiFilePath)
        {
            this.Type = MatrixType.Transformed;
            var asciiBlock = this.ReadFromAsciiFile(asciiFilePath);
            this.ParseAsciiBlock(asciiBlock);

            // check length of each row and adjust size to 2^(log2(len))
            var longestRow = this.Rows.OrderByDescending(r => r.ColumnCount).FirstOrDefault();
            if (longestRow == null)
            {
                return;
            }

            Trace.WriteLine(string.Format("Longest column count: {0}.", longestRow.ColumnCount));

            // calculate the required transformation levels as log2(longest)
            var levelCount = Math.Log(longestRow.ColumnCount, 2.0);
            Trace.WriteLine(string.Format("Transformation level count: {0}.", levelCount));

            var rowLenght = this.CalculateRowLength(levelCount);
            Trace.WriteLine(string.Format("Row length: {0}.", rowLenght));

            // fill up rows with zeros
            if (longestRow.ColumnCount != rowLenght)
            {
                foreach (var row in this.Rows)
                {
                    while (row.ColumnCount < rowLenght)
                    {
                        row.AddColumn(0x00);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        public MatrixType Type { get; private set; }

        /// <summary>
        /// Gets or sets the rows.
        /// </summary>
        /// <value>
        /// The rows.
        /// </value>
        public List<DataRow> Rows { get; set; }

        /// <summary>
        /// Gets the column count.
        /// </summary>
        public int ColumnCount { get; private set; }

        public int MaxLevelCount { get; private set; }

        /// <summary>
        /// Retransforms this instance.
        /// </summary>
        /// <returns></returns>
        public DataMatrix Retransform(int levelCount)
        {
            var matrix = new DataMatrix(MatrixType.Retransformed, this.ColumnCount);

            foreach (DataRow row in this.Rows)
            {
                int halfGroupCount = this.ColumnCount;

                var tmpRow = row.RowValues.ToArray();
                for (int currentLevel = 0; currentLevel < levelCount; currentLevel++)
                {
                    halfGroupCount = halfGroupCount / 2;
                    int groupLen = Convert.ToInt32(Math.Pow(2.0, currentLevel));
                    for (int j = 0; j < halfGroupCount; j++)
                    {
                        var r = tmpRow.ToList().ToArray();
                        var s = tmpRow.ToList().ToArray();

                        var groupOffset = (this.ColumnCount * j) / halfGroupCount;
                        for (int i = 0; i < groupLen; i++)
                        {
                            var a = tmpRow[groupOffset + i];
                            var d = tmpRow[groupOffset + groupLen + i];

                            r[i] = (a + d) / Math.Sqrt(2.0);
                            s[i] = (a - d) / Math.Sqrt(2.0);
                            
                            // r[i] = (tmpRow[p + i] + tmpRow[p + h + i]) / Math.Sqrt(2.0);
                            // s[i] = (tmpRow[p + i] - tmpRow[p + h + i]) / Math.Sqrt(2.0);
                        }


                        for (int i = 0; i < groupLen; i++)
                        {
                            tmpRow[groupOffset + (2 * i)] = r[i];
                            tmpRow[groupOffset + (2 * i) + 1] = s[i];
                        }

                    }
                }

                for (int i = 0; i < tmpRow.Count(); i++)
                {
                    tmpRow[i] = Math.Round(tmpRow[i], 0);
                }

                var nr = new DataRow(tmpRow);
                matrix.Rows.Add(nr);
            }

            return matrix;
        }

        /// <summary>
        /// Reads from ASCII file.
        /// </summary>
        /// <param name="inputFilePath">The input file path.</param>
        /// <returns></returns>
        public string ReadFromAsciiFile(string inputFilePath)
        {
            return File.Exists(inputFilePath) == false
                       ? string.Empty
                       : File.ReadAllText(inputFilePath);
        }

        /// <summary>
        /// Calculates the length of the row as 2^z.
        /// </summary>
        /// <param name="levelCount">The level count.</param>
        /// <returns>The signal length.</returns>
        private int CalculateRowLength(double levelCount)
        {
            this.MaxLevelCount = Convert.ToInt32(Math.Floor(levelCount));
            if (Math.Abs(levelCount - Math.Floor(levelCount)) > double.Epsilon)
            {
                this.MaxLevelCount++;
                var newRowLength = Convert.ToInt32(Math.Pow(2.0, Math.Floor(levelCount) + 1));
                Trace.WriteLine(string.Format("Adjusted row length: {0}.", newRowLength));
                this.ColumnCount = newRowLength;
                return newRowLength;
            }

            this.ColumnCount = Convert.ToInt32(Math.Pow(2.0, Math.Floor(levelCount)));

            return this.ColumnCount;
        }

        /// <summary>
        /// Parses the ASCII block.
        /// </summary>
        /// <param name="asciiBlock">The ASCII block.</param>
        private void ParseAsciiBlock(string asciiBlock)
        {
            var rawRows = asciiBlock.Split(new[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            this.Rows = new List<DataRow>(rawRows.Length);

            foreach (var rawRow in rawRows)
            {
                var tempRow = new List<double>();
                var byteStrings = rawRow.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var byteString in byteStrings)
                {
                    var b = byte.Parse(byteString.Trim());
                    tempRow.Add(b);
                }

                Trace.WriteLine(tempRow.Count);

                this.Rows.Add(new DataRow(tempRow.ToArray()));
            }
        }

        /// <summary>
        /// Writes to ASCII file.
        /// </summary>
        /// <param name="outputFilePath">The output file path.</param>
        public void WriteToAsciiFile(string outputFilePath)
        {
            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath);
            }

            File.WriteAllText(outputFilePath, this.ToString());
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var row in this.Rows)
            {
                row.RowValues.ForEach(b => sb.AppendFormat("{0}\t", Convert.ToString(b)));
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}