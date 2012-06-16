namespace Wavelet.DataModel
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents one transformed group
    /// </summary>
    public class DataGroup : List<double>
    {
        public DataGroup()
        {
        }

        public DataGroup(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataGroup"/> class.
        /// </summary>
        /// <param name="level">The level.</param>
        public DataGroup(int level, int index)
        {
            this.Level = level;
            this.LevelIndex = index;
        }

        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int LevelIndex { get; set; }
    }
}