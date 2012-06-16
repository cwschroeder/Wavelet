namespace Wavelet.DataModel
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents one image row.
    /// </summary>
    public class DataRow
    {
        /// <summary>
        /// Encapsulated row bytes.
        /// </summary>
        private List<double> rowValues;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRow"/> class.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        public DataRow(double[] bytes)
        {
            this.rowValues = new List<double>(bytes);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRow"/> class.
        /// </summary>
        /// <param name="groups">The groups.</param>
        public DataRow(IEnumerable<DataGroup> groups)
        {
            this.rowValues = new List<double>();
            foreach (var group in groups)
            {
                this.rowValues.AddRange(group);
            }
        }

        /// <summary>
        /// Gets the column count.
        /// </summary>
        public int ColumnCount
        {
            get
            {
                return this.RowValues.Count;
            }
        }
        
        /// <summary>
        /// Gets the row bytes.
        /// </summary>
        public List<double> RowValues
        {
            get
            {
                return this.rowValues;
            }
        }

        /// <summary>
        /// Adds the column.
        /// </summary>
        /// <param name="val">The val.</param>
        public void AddColumn(byte val)
        {
            this.rowValues.Add(val);
        }

        /// <summary>
        /// Calculates the groups.
        /// </summary>
        /// <param name="level">The level.</param>
        /// <returns>List of datagroups calculated until the the given level</returns>
        public List<DataGroup> CalculateTransformedGroups(int level)
        {
            var initialGroup = new DataGroup();
            initialGroup.AddRange(this.rowValues);
            var levelGroups = new List<DataGroup>() { initialGroup };

            // Calculate transformed matrix row here
            for (int i = 0; i < level; i++)
            {
               levelGroups = this.TransformLevelGroups(levelGroups);
            }

            return levelGroups;
        }

        /// <summary>
        /// Transforms the level groups.
        /// </summary>
        /// <param name="groups">The groups.</param>
        /// <returns>List of DataGroups as result of one transformation level.</returns>
        private List<DataGroup> TransformLevelGroups(IEnumerable<DataGroup> groups)
        {
            var levelGroups = new List<DataGroup>();
            foreach (var group in groups)
            {
                var resultGroups = this.TransformGroup(group);
                levelGroups.AddRange(resultGroups);
            }

            return levelGroups;
        }

        /// <summary>
        /// Transforms the group.
        /// </summary>
        /// <param name="inputGroup">The input group.</param>
        /// <returns>Two result groups as result of one transformation step.</returns>
        private DataGroup[] TransformGroup(DataGroup inputGroup)
        {
            var addGroup = new DataGroup("+");
            for (int i = 0; i < inputGroup.Count; i += 2)
            {
                var val = (inputGroup[i] + inputGroup[i + 1]) / Math.Sqrt(2.0);
                var roundedVal = Math.Round(val, 3);
                addGroup.Add(roundedVal);
            }

            var subGroup = new DataGroup("-");
            for (int i = 0; i < inputGroup.Count; i += 2)
            {
                var val = (inputGroup[i] - inputGroup[i + 1]) / Math.Sqrt(2.0);
                var roundedVal = Math.Round(val, 3);
                subGroup.Add(roundedVal);
            }

            return new[] { addGroup, subGroup };
        }
    }
}