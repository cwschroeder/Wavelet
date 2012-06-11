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
   public partial class CtrlRawdataView : UserControl
   {
      public CtrlRawdataView()
      {
         InitializeComponent();
      }

      /// <summary>
      /// Sets the orginial image.
      /// </summary>
      /// <param name="image">The image.</param>
      public void SetOrginialImage(Bitmap image, string fileName, long fileSize)
      {
         // fill picture box
         this.pictureBoxUntransformed.SizeMode = PictureBoxSizeMode.Zoom;
         //this.pictureBoxUntransformed.ClientSize = new Size(image.Height, image.Width);
         this.pictureBoxUntransformed.Image = image;

         // fill textbox
         this.txtPicUntransformedInfo.Text = string.Format(
            "Original file\n\n\nFile Name: {0}\n\nFile Size: {1} Bytes\n", fileName, fileSize);
      }

      /// <summary>
      /// Sets the transformed image.
      /// </summary>
      /// <param name="image">The image.</param>
      /// <param name="fileName">Name of the file.</param>
      public void SetTransformedImage(Bitmap image, string fileName, int fileSize)
      {
         throw new NotImplementedException();
      }
   }
}
