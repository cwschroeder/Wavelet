using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wavelet
{
    using System.IO;

    public partial class FrmMain : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmMain"/> class.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the tabCtrlMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TabCtrlMainSelectedIndexChanged(object sender, EventArgs e)
        {
            var wt = Core.WaveletTransform.Instance;

            switch (this.tabCtrlMain.SelectedIndex)
            {
                case 0:
                    // file view
                    break;
                case 1:
                    // rawdata view (image)
                    if (wt == null)
                    {
                        break;
                    }

                    wt.LoadImages();

                    if (File.Exists(wt.OriginalImageFilePath))
                    {
                        var fi = new FileInfo(wt.OriginalImageFilePath);
                        this.ctrlRawdataView1.SetOriginalImage(wt.OriginalImage, wt.OriginalImageFilePath, fi.Length);
                    }

                    if (File.Exists(wt.TransformedImageFilePath))
                    {
                        var fi = new FileInfo(wt.TransformedImageFilePath);
                        this.ctrlRawdataView1.SetTransformedImage(wt.TransformedImage, wt.TransformedImageFilePath, fi.Length);
                    }

                    if (File.Exists(wt.RetransformedImageFilePath))
                    {
                        var fi = new FileInfo(wt.RetransformedImageFilePath);
                        this.ctrlRawdataView1.SetRetransformedImage(wt.RetransformedImage, wt.RetransformedImageFilePath, fi.Length);
                    }

                    this.ctrlRawdataView1.Refresh();
                    break;
                case 2:
                    // ascii data view
                    if (wt == null)
                    {
                        break;
                    }

                    // Call view to update
                    this.ctrlAsciiView1.SetAsciiData(wt);
                    break;
                case 3:
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        private void ctrlFileView1_Load(object sender, EventArgs e)
        {

        }
    }
}
