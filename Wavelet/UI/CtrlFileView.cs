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
      public static readonly Logger Logger = LogManager.GetCurrentClassLogger();

      /// <summary>
      /// Gets the original image.
      /// </summary>
      public Bitmap OriginalImage { get; private set; }

      /// <summary>
      /// Gets the transformed image.
      /// </summary>
      public Bitmap TransformedImage { get; private set; }

      /// <summary>
      /// Gets the original image file path.
      /// </summary>
      public string OriginalImageFilePath
      {
         get
         {
            return this.txtUntransformedImageFileName.Text;
         }
      }

      /// <summary>
      /// Gets the untrasformed ASCII file path.
      /// </summary>
      public string UntrasformedAsciiFilePath
      {
         get
         {
            return this.txtUntransformedAsciiFileName.Text;
         }
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="CtrlFileView"/> class.
      /// </summary>
      public CtrlFileView()
      {
         InitializeComponent();

         // Init
         var filePath = Path.Combine(Directory.GetCurrentDirectory(), "SampleData");
         this.txtUntransformedImageFileName.Text = Path.Combine(filePath, "baracktocat.jpg");
      }

      /// <summary>
      /// Uses the path settings entered by user.
      /// </summary>
      /// <param name="sender">The sender.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void CmdFilesOkClick(object sender, EventArgs e)
      {
         // 0) Clear non-static pathes
         this.txtUntransformedAsciiFileName.Text = string.Empty;
         this.txtTransformedAsciiFileName.Text = string.Empty;
         this.txtTransformedImageFileName.Text = string.Empty;

         // 1) Load originial image file
         this.LoadOriginalImage();

         // 2) Call external program to create ASCII file from loaded image
         this.ExecuteExternalApp(TimeSpan.FromSeconds(2), this.OriginalImageFilePath);
         var untransformedAsciiFileName = string.Concat(Path.GetFileNameWithoutExtension(this.OriginalImageFilePath), ".txt");
         this.txtUntransformedAsciiFileName.Text = Path.Combine(Directory.GetCurrentDirectory(), untransformedAsciiFileName);

         // 3) Initalize and call core transformation function
         var wt = new Wavelet.Core.WaveletTransform(this.UntrasformedAsciiFilePath);
         wt.TransformAllRows();
         this.txtTransformedAsciiFileName.Text = wt.TransformedAsciiFilePath;

         // 4) Call external program to create image file from transformed ASCII file
         this.ExecuteExternalApp(TimeSpan.FromSeconds(2), wt.TransformedAsciiFilePath);
         var transformedImageFileName = string.Concat(Path.GetFileNameWithoutExtension(this.OriginalImageFilePath), "_trans.png");
         this.txtTransformedImageFileName.Text = Path.Combine(Directory.GetCurrentDirectory(), transformedImageFileName);
      }

      /// <summary>
      /// Executes the ASCII generator.
      /// </summary>
      /// <param name="timeout">The timeout.</param>
      private void ExecuteExternalApp(TimeSpan timeout, string argumentFilePath)
      {
         var psi = new ProcessStartInfo
            {
               CreateNoWindow = false,
               UseShellExecute = false,
               WindowStyle = ProcessWindowStyle.Normal,
               FileName = "SmartProgramWrittenByDoktorand.exe",
               Arguments = argumentFilePath
            };
         
         try
         {
            using (var proc = Process.Start(psi))
            {
               proc.WaitForExit((int)timeout.TotalMilliseconds);
            }

            var success = true;
            //TODO: check for correct process execution here...

            if (success == false)
            {
               throw new ApplicationException("External program from Doktorand failed somehow!");
            }
         }
         catch (TimeoutException tex)
         {
            Logger.ErrorException("Timeout", tex);
            // TODO: set main form status label error text
         }
         catch (Exception ex)
         {
            Logger.ErrorException("Error", ex);
            // TODO: set main form status label error text
         }
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
   }
}
