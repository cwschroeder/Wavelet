// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WaveletTransform.cs" company="">
//   
// </copyright>
// <summary>
//   TODO: Update summary.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wavelet.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;

    using Wavelet.DataModel;

    /// <summary>
    /// Core wavelet transformation.
    /// </summary>
    public class WaveletTransform
    {
        // File pathes
        #region Static Fields

        /// <summary>
        /// The instance.
        /// </summary>
        private static WaveletTransform instance;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WaveletTransform"/> class.
        /// </summary>
        /// <param name="originalImageFilePath">The original Image File Path.</param>
        /// <param name="untransformedAsciiFilePath">The untransformed ASCII file path.</param>
        /// <param name="transformedAsciiFilePath">The transformed Ascii File Path.</param>
        /// <param name="transformedImageFilePath">The transformed Image File Path.</param>
        /// <param name="retransformedAsciiFilePath">The retransformed Ascii File Path.</param>
        /// <param name="retransformedImageFilePath">The retransformed Image File Path.</param>
        private WaveletTransform(
            string originalImageFilePath, 
            string untransformedAsciiFilePath, 
            string transformedAsciiFilePath, 
            string transformedImageFilePath, 
            string retransformedAsciiFilePath, 
            string retransformedImageFilePath)
        {
            this.OriginalImageFilePath = originalImageFilePath;
            this.UntransformedAsciiFilePath = untransformedAsciiFilePath;

            this.TransformedAsciiFilePath = transformedAsciiFilePath;
            this.TransformedImageFilePath = transformedImageFilePath;

            this.RetransformedAsciiFilePath = retransformedAsciiFilePath;
            this.RetransformedImageFilePath = retransformedImageFilePath;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets Instance.
        /// </summary>
        public static WaveletTransform Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Gets CurrentGroup.
        /// </summary>
        public int CurrentGroup { get; private set; }

        /// <summary>
        /// Gets CurrentRow.
        /// </summary>
        public int CurrentRow { get; private set; }

        /// <summary>
        /// Gets CurrentStep.
        /// </summary>
        public int CurrentStep { get; private set; }

        /// <summary>
        /// Gets LastGroup.
        /// </summary>
        public int? LastGroup { get; private set; }

        /// <summary>
        /// Gets LastRow.
        /// </summary>
        public int? LastRow { get; private set; }

        /// <summary>
        /// Gets LastStep.
        /// </summary>
        public int? LastStep { get; private set; }

        /// <summary>
        /// Gets OriginalImageFilePath.
        /// </summary>
        public string OriginalImageFilePath { get; private set; }

        /// <summary>
        /// Gets or sets RetransformedAsciiFilePath.
        /// </summary>
        public string RetransformedAsciiFilePath { get; set; }

        /// <summary>
        /// Gets or sets RetransformedImageFilePath.
        /// </summary>
        public string RetransformedImageFilePath { get; set; }

        /// <summary>
        /// Gets TransformedAsciiFilePath.
        /// </summary>
        public string TransformedAsciiFilePath { get; private set; }

        /// <summary>
        /// Gets TransformedImageFilePath.
        /// </summary>
        public string TransformedImageFilePath { get; private set; }

        /// <summary>
        /// Gets the original image.
        /// </summary>
        public Bitmap OriginalImage { get; private set; }

        /// <summary>
        /// Gets the transformed image.
        /// </summary>
        public Bitmap TransformedImage { get; private set; }

        /// <summary>
        /// Gets the retransformed image.
        /// </summary>
        public Bitmap RetransformedImage { get; private set; }


        /// <summary>
        /// Gets UntransformedAsciiFileContent.
        /// </summary>
        public string UntransformedAsciiFileContent
        {
            get
            {
                return File.Exists(this.UntransformedAsciiFilePath) == false
                           ? string.Empty
                           : File.ReadAllText(this.UntransformedAsciiFilePath);
            }
        }

        /// <summary>
        /// Gets UntransformedAsciiFilePath.
        /// </summary>
        public string UntransformedAsciiFilePath { get; private set; }

        public string TransformedAsciiFileContent
        {
            get
            {
                return File.Exists(this.TransformedAsciiFilePath) == false
                   ? string.Empty
                   : File.ReadAllText(this.TransformedAsciiFilePath);
                    }
        }

        public DataMatrix OriginalMatrix { get; set; }

        public DataMatrix RetransformedMatrix { get; private set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The init.
        /// </summary>
        /// <param name="originalImageFilePath">The original image file path.</param>
        /// <param name="untransformedAsciiFilePath">The untransformed ascii file path.</param>
        /// <param name="transformedAsciiFilePath">The transformed ascii file path.</param>
        /// <param name="transformedImageFilePath">The transformed image file path.</param>
        /// <param name="retransformedAsciiFilePath">The retransformed ASCII file path.</param>
        /// <param name="retransformedImageFilePath">The retransformed image file path.</param>
        public static void Init(
            string originalImageFilePath, 
            string untransformedAsciiFilePath, 
            string transformedAsciiFilePath, 
            string transformedImageFilePath,
            string retransformedAsciiFilePath,
            string retransformedImageFilePath)
        {
            if (string.IsNullOrEmpty(untransformedAsciiFilePath))
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(transformedAsciiFilePath))
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(transformedImageFilePath))
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(retransformedAsciiFilePath))
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(retransformedImageFilePath))
            {
                throw new ArgumentNullException();
            }

            if (File.Exists(untransformedAsciiFilePath) == false)
            {
                throw new ArgumentException("Ascii input file not found.");
            }

            instance = new WaveletTransform(
                originalImageFilePath, untransformedAsciiFilePath, transformedAsciiFilePath, transformedImageFilePath, retransformedAsciiFilePath, retransformedImageFilePath);
        }

        /// <summary>
        /// Transforms all rows.
        /// </summary>
        public void TransformAllRows()
        {
            this.OriginalMatrix = new DataMatrix(this.UntransformedAsciiFilePath);
            Trace.WriteLine(string.Format("Original matrix ascii import completed, imported {0} rows.", this.OriginalMatrix.Rows.Count));

            var matrixTrans = new DataMatrix(MatrixType.Transformed, this.OriginalMatrix.ColumnCount);

            // transform row by row
            for (int i = 0; i < this.OriginalMatrix.Rows.Count; i++)
            {
                // use the required level
                var groups = this.OriginalMatrix.Rows[i].CalculateTransformedGroups(this.OriginalMatrix.MaxLevelCount);
                matrixTrans.Rows.Add(new DataRow(groups));
            }
            
            // create output ascii file for transformed matrix
            matrixTrans.WriteToAsciiFile(this.TransformedAsciiFilePath);

            this.TransformedMatrix = matrixTrans;
        }

        /// <summary>
        /// The transform single step.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="step">The step.</param>
        /// <returns></returns>
        public List<DataGroup> TransformSingleStep(int row, int step)
        {
            var matrixOrig = new DataMatrix(this.UntransformedAsciiFilePath);
            Trace.WriteLine(string.Format("Original matrix ascii import completed, imported {0} rows.", matrixOrig.Rows.Count));

            var dataRow = matrixOrig.Rows[row];
            var groups = dataRow.CalculateTransformedGroups(step);
            return groups;
        }

        /// <summary>
        /// Retransforms all rows.
        /// </summary>
        public void RetransformAllRows()
        {
            if (this.OriginalMatrix == null)
            {
                throw new InvalidOperationException("No original matrix for reconversion available!");
            }

            this.RetransformedMatrix = this.TransformedMatrix.Retransform(this.OriginalMatrix.MaxLevelCount);
        }

        protected DataMatrix TransformedMatrix { get; set; }

        public void LoadImages()
        {
            this.LoadOriginalImage();
            this.LoadTransformedImage();
            this.LoadRetransformedImage();
        }

        /// <summary>
        /// Loads the original image.
        /// </summary>
        private void LoadOriginalImage()
        {
            if (File.Exists(this.OriginalImageFilePath))
            {
                this.OriginalImage = new Bitmap(this.OriginalImageFilePath);
            }
            else
            {
                this.OriginalImage = null;
            }
        }

        /// <summary>
        /// Loads the transformed image.
        /// </summary>
        private void LoadTransformedImage()
        {
            if (File.Exists(this.TransformedImageFilePath))
            {
                this.TransformedImage = new Bitmap(this.TransformedImageFilePath);
            }
            else
            {
                this.TransformedImage = null;
            }
        }

        /// <summary>
        /// Loads the retransformed image.
        /// </summary>
        private void LoadRetransformedImage()
        {
            if (File.Exists(this.RetransformedImageFilePath))
            {
                this.RetransformedImage = new Bitmap(this.RetransformedImageFilePath);
            }
            else
            {
                this.RetransformedImage = null;
            }
        }

        #endregion
    }
}