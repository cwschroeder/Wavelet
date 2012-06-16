namespace Wavelet.UI
{
   partial class CtrlFileView
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.panelFiles = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUntransformedImageFileName = new System.Windows.Forms.TextBox();
            this.txtUntransformedAsciiFileName = new System.Windows.Forms.TextBox();
            this.txtTransformedAsciiFileName = new System.Windows.Forms.TextBox();
            this.txtTransformedImageFileName = new System.Windows.Forms.TextBox();
            this.cmdFilesOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetransformedAsciiFileName = new System.Windows.Forms.TextBox();
            this.txtRetransformedImageFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiles
            // 
            this.panelFiles.ColumnCount = 3;
            this.panelFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.06878F));
            this.panelFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.93122F));
            this.panelFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFiles.Controls.Add(this.label1, 0, 1);
            this.panelFiles.Controls.Add(this.label2, 0, 3);
            this.panelFiles.Controls.Add(this.label3, 0, 2);
            this.panelFiles.Controls.Add(this.label4, 0, 4);
            this.panelFiles.Controls.Add(this.txtUntransformedImageFileName, 1, 1);
            this.panelFiles.Controls.Add(this.txtUntransformedAsciiFileName, 1, 2);
            this.panelFiles.Controls.Add(this.txtTransformedAsciiFileName, 1, 3);
            this.panelFiles.Controls.Add(this.txtTransformedImageFileName, 1, 4);
            this.panelFiles.Controls.Add(this.cmdFilesOk, 2, 8);
            this.panelFiles.Controls.Add(this.label6, 0, 5);
            this.panelFiles.Controls.Add(this.label5, 0, 6);
            this.panelFiles.Controls.Add(this.txtRetransformedAsciiFileName, 1, 5);
            this.panelFiles.Controls.Add(this.txtRetransformedImageFileName, 1, 6);
            this.panelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiles.Location = new System.Drawing.Point(0, 0);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.RowCount = 10;
            this.panelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelFiles.Size = new System.Drawing.Size(756, 381);
            this.panelFiles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rohdatei (*.png)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transformierte ASCII-Datei (*_trans.txt)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ASCII-Datei (*.txt)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transformierte Bilddatei (*_trans.png)";
            // 
            // txtUntransformedImageFileName
            // 
            this.txtUntransformedImageFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUntransformedImageFileName.Location = new System.Drawing.Point(226, 53);
            this.txtUntransformedImageFileName.Name = "txtUntransformedImageFileName";
            this.txtUntransformedImageFileName.Size = new System.Drawing.Size(445, 20);
            this.txtUntransformedImageFileName.TabIndex = 4;
            this.txtUntransformedImageFileName.Text = "baracktocat.jpg";
            // 
            // txtUntransformedAsciiFileName
            // 
            this.txtUntransformedAsciiFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUntransformedAsciiFileName.Location = new System.Drawing.Point(226, 83);
            this.txtUntransformedAsciiFileName.Name = "txtUntransformedAsciiFileName";
            this.txtUntransformedAsciiFileName.Size = new System.Drawing.Size(445, 20);
            this.txtUntransformedAsciiFileName.TabIndex = 5;
            // 
            // txtTransformedAsciiFileName
            // 
            this.txtTransformedAsciiFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTransformedAsciiFileName.Location = new System.Drawing.Point(226, 133);
            this.txtTransformedAsciiFileName.Name = "txtTransformedAsciiFileName";
            this.txtTransformedAsciiFileName.Size = new System.Drawing.Size(445, 20);
            this.txtTransformedAsciiFileName.TabIndex = 6;
            // 
            // txtTransformedImageFileName
            // 
            this.txtTransformedImageFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTransformedImageFileName.Location = new System.Drawing.Point(226, 163);
            this.txtTransformedImageFileName.Name = "txtTransformedImageFileName";
            this.txtTransformedImageFileName.Size = new System.Drawing.Size(445, 20);
            this.txtTransformedImageFileName.TabIndex = 7;
            // 
            // cmdFilesOk
            // 
            this.cmdFilesOk.Location = new System.Drawing.Point(677, 323);
            this.cmdFilesOk.Name = "cmdFilesOk";
            this.cmdFilesOk.Size = new System.Drawing.Size(75, 23);
            this.cmdFilesOk.TabIndex = 11;
            this.cmdFilesOk.Text = "OK";
            this.cmdFilesOk.UseVisualStyleBackColor = true;
            this.cmdFilesOk.Click += new System.EventHandler(this.CmdFilesOkClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Retransformierte ASCII-Datei (*_retrans.txt)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Retransformierte Bilddatei (*_retrans.png)";
            // 
            // txtRetransformedAsciiFileName
            // 
            this.txtRetransformedAsciiFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRetransformedAsciiFileName.Location = new System.Drawing.Point(226, 213);
            this.txtRetransformedAsciiFileName.Name = "txtRetransformedAsciiFileName";
            this.txtRetransformedAsciiFileName.Size = new System.Drawing.Size(445, 20);
            this.txtRetransformedAsciiFileName.TabIndex = 14;
            // 
            // txtRetransformedImageFileName
            // 
            this.txtRetransformedImageFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRetransformedImageFileName.Location = new System.Drawing.Point(226, 243);
            this.txtRetransformedImageFileName.Name = "txtRetransformedImageFileName";
            this.txtRetransformedImageFileName.Size = new System.Drawing.Size(445, 20);
            this.txtRetransformedImageFileName.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CtrlFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFiles);
            this.Name = "CtrlFileView";
            this.Size = new System.Drawing.Size(756, 381);
            this.panelFiles.ResumeLayout(false);
            this.panelFiles.PerformLayout();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel panelFiles;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtUntransformedImageFileName;
      private System.Windows.Forms.TextBox txtUntransformedAsciiFileName;
      private System.Windows.Forms.TextBox txtTransformedAsciiFileName;
      private System.Windows.Forms.TextBox txtTransformedImageFileName;
      private System.Windows.Forms.Button cmdFilesOk;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox txtRetransformedAsciiFileName;
      private System.Windows.Forms.TextBox txtRetransformedImageFileName;
   }
}
