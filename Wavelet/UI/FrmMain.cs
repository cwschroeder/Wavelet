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
      private void tabCtrlMain_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch (tabCtrlMain.SelectedIndex)
         {
            case 0:
               break;
            case 1:
               var fi = new FileInfo(this.ctrlFileView1.OriginalImageFilePath);
               this.ctrlRawdataView1.SetOrginialImage(this.ctrlFileView1.OriginalImage, this.ctrlFileView1.OriginalImageFilePath, fi.Length);
               this.ctrlRawdataView1.Refresh();
               break;
            case 2:
               break;
            case 3:
               break;
            default:
               throw new InvalidEnumArgumentException();
         }
      }
   }
}
