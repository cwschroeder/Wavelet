// -----------------------------------------------------------------------
// <copyright file="WaveletTransform.cs" company="Hewlett-Packard Company">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Wavelet.Core
{
   using System;
   using System.Collections.Generic;
   using System.IO;
   using System.Linq;
   using System.Text;

   /// <summary>
   /// TODO: Update summary.
   /// </summary>
   public class WaveletTransform
   {
      private string untransformedAsciiFilePath;

      public string TransformedAsciiFilePath
      {
         get
         {
            if (this.TransformedRowList == null)
            {
               //return string.Empty;
            }

            var tmp = string.Concat(Path.GetFileNameWithoutExtension(untransformedAsciiFilePath), "_trans.txt");
            return Path.Combine(Directory.GetCurrentDirectory(), tmp);
         }
      }

      private List<byte[]> untransformedRowList;

      public List<byte[]> TransformedRowList { get; private set; }

      public int CurrentRow { get; private set; }

      public int CurrentGroup { get; private set; }

      public int CurrentStep { get; private set; }

      public int? LastRow { get; private set; }

      public int? LastGroup { get; private set; }

      public int? LastStep { get; private set; }

      
      /// <summary>
      /// Initializes a new instance of the <see cref="WaveletTransform"/> class.
      /// </summary>
      /// <param name="untransformedAsciiFilePath">The untransformed ASCII file path.</param>
      public WaveletTransform (string untransformedAsciiFilePath)
      {
         if (string.IsNullOrEmpty(untransformedAsciiFilePath))
         {
            //throw new ArgumentNullException();
         }

         if (File.Exists(untransformedAsciiFilePath) == false)
         {
            //throw new ArgumentException("Ascii input file not found.");
         }

         this.untransformedAsciiFilePath = untransformedAsciiFilePath;
         this.untransformedRowList = new List<byte[]>();
      }

      /// <summary>
      /// Transforms all rows.
      /// </summary>
      public void TransformAllRows()
      {
         //throw new NotImplementedException();
      }

      public void TransformSingleStep(int row, int group, int step)
      {
         //throw new NotImplementedException();
      }
   }
}
