using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wavelet.UI
{
    using System.Diagnostics;
    using System.IO;

    using NLog;

    public partial class CtrlFileView : UserControl
    {
        /// <summary>
        /// Create logger instance.
        /// </summary>
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Gets the DataDirPathName.
        /// </summary>
        public string DataDirPathName
        {
            get
            {
                return Path.Combine(Directory.GetCurrentDirectory(), "Data");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CtrlFileView"/> class.
        /// </summary>
        public CtrlFileView()
        {
            this.InitializeComponent();

            // Init
            this.txtUntransformedImageFileName.Text = Path.Combine(this.DataDirPathName, "baracktocat.jpg");
        }

        /// <summary>
        /// Uses the path settings entered by user.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CmdFilesOkClick(object sender, EventArgs e)
        {
            // 1) Clear non-static pathes
            this.txtUntransformedAsciiFileName.Text = string.Empty;
            this.txtTransformedAsciiFileName.Text = string.Empty;
            this.txtTransformedImageFileName.Text = string.Empty;
            this.txtRetransformedAsciiFileName.Text = string.Empty;
            this.txtRetransformedImageFileName.Text = string.Empty;
            
            // 2) Set path name for ascii file created from raw image by external program
            var untransformedAsciiFileName = string.Concat(Path.GetFileNameWithoutExtension(this.txtUntransformedImageFileName.Text), ".txt");
            this.txtUntransformedAsciiFileName.Text = Path.Combine(this.DataDirPathName, untransformedAsciiFileName);

            // 3) Set path name for transformed ascii file created by this application's wavelet transform function
            var tmp = string.Concat(Path.GetFileNameWithoutExtension(this.txtUntransformedAsciiFileName.Text), "_trans.txt");
            this.txtTransformedAsciiFileName.Text = Path.Combine(Path.GetDirectoryName(this.txtUntransformedAsciiFileName.Text), tmp);

            // 4) Set paht name for image file created by external program from transformed ascii file 
            var transformedImageFileName = string.Concat(Path.GetFileNameWithoutExtension(this.txtUntransformedImageFileName.Text), "_trans.png");
            this.txtTransformedImageFileName.Text = Path.Combine(this.DataDirPathName, transformedImageFileName);

            // 5) Set path name for retransformed ascii file created by this application's wavelet retransform function
            tmp = string.Concat(Path.GetFileNameWithoutExtension(this.txtUntransformedAsciiFileName.Text), "_retrans.txt");
            this.txtRetransformedAsciiFileName.Text = Path.Combine(Path.GetDirectoryName(this.txtUntransformedAsciiFileName.Text), tmp);

            // 6) Set path name for image file created by external program from retransformed ascii file 
            var retransformedImageFileName = string.Concat(Path.GetFileNameWithoutExtension(this.txtUntransformedImageFileName.Text), "_retrans.png");
            this.txtRetransformedImageFileName.Text = Path.Combine(this.DataDirPathName, retransformedImageFileName);


            Core.WaveletTransform.Init(
                this.txtUntransformedImageFileName.Text, 
                this.txtUntransformedAsciiFileName.Text, 
                this.txtTransformedAsciiFileName.Text, 
                this.txtTransformedImageFileName.Text,
                this.txtRetransformedAsciiFileName.Text,
                this.txtRetransformedImageFileName.Text);
            if (Core.WaveletTransform.Instance == null)
            {
                throw new NullReferenceException();
            }
        }
    }
}
