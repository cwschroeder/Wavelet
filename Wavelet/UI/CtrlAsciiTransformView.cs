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
    public partial class CtrlAsciiTransformView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CtrlAsciiTransformView"/> class.
        /// </summary>
        public CtrlAsciiTransformView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the ASCII data.
        /// </summary>
        /// <param name="wt">The wt.</param>
        public void SetAsciiData(Core.WaveletTransform wt)
        {
            if (wt == null)
            {
                throw new NullReferenceException();
            }

            this.AssignNormalizedTextLines(wt.UntransformedAsciiFileContent, this.txtAsciiUntransformed);
            this.txtAsciiUntransformedInfo.Text = "info...";

            this.AssignNormalizedTextLines(wt.TransformedAsciiFileContent, this.txtAsciiTransformed);
            this.txtAsciiTransformedInfo.Text = "info...";
        }

        /// <summary>
        /// Assigns the normalized text lines.
        /// </summary>
        /// <param name="fileContent">Content of the file.</param>
        /// <param name="textBox">The text box.</param>
        private void AssignNormalizedTextLines(string fileContent, RichTextBox textBox)
        {
            var lines = fileContent.Split(new[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                textBox.Text += line + "\n";
            }
        }

        /// <summary>
        /// Handles the transform click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CmdTransformClick(object sender, EventArgs e)
        {
            var wt = Core.WaveletTransform.Instance;
            if (wt == null)
            {
                MessageBox.Show("Wavelet engine not initialized.");
                return;
            }
            try
            {
                wt.TransformAllRows();
                this.txtAsciiTransformed.Text = wt.TransformedAsciiFileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the retransform click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CmdRetransformClick(object sender, EventArgs e)
        {
            var wt = Core.WaveletTransform.Instance;
            if (wt == null)
            {
                MessageBox.Show("Wavelet engine not initialized.");
                return;
            }

            try
            {
                wt.RetransformAllRows();
                this.txtAsciiUntransformed.Text = wt.RetransformedMatrix.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
