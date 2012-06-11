namespace Wavelet.UI
{
   partial class CtrlAsciiView
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
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.dgvUntransformed = new System.Windows.Forms.DataGridView();
         this.dgvTransformed = new System.Windows.Forms.DataGridView();
         this.txtAsciiUntransformedInfo = new System.Windows.Forms.RichTextBox();
         this.txtAsciiTransformedInfo = new System.Windows.Forms.RichTextBox();
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.txtTransformationFactor = new System.Windows.Forms.MaskedTextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvUntransformed)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvTransformed)).BeginInit();
         this.flowLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 3;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Controls.Add(this.dgvUntransformed, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 4);
         this.tableLayoutPanel1.Controls.Add(this.dgvTransformed, 0, 6);
         this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
         this.tableLayoutPanel1.Controls.Add(this.label3, 2, 6);
         this.tableLayoutPanel1.Controls.Add(this.txtAsciiUntransformedInfo, 2, 3);
         this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
         this.tableLayoutPanel1.Controls.Add(this.txtAsciiTransformedInfo, 2, 8);
         this.tableLayoutPanel1.Controls.Add(this.label5, 2, 7);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 12;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 436);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // dgvUntransformed
         // 
         this.dgvUntransformed.AllowUserToAddRows = false;
         this.dgvUntransformed.AllowUserToDeleteRows = false;
         this.dgvUntransformed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvUntransformed.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dgvUntransformed.Location = new System.Drawing.Point(3, 53);
         this.dgvUntransformed.Name = "dgvUntransformed";
         this.dgvUntransformed.ReadOnly = true;
         this.tableLayoutPanel1.SetRowSpan(this.dgvUntransformed, 4);
         this.dgvUntransformed.Size = new System.Drawing.Size(327, 251);
         this.dgvUntransformed.TabIndex = 0;
         // 
         // dgvTransformed
         // 
         this.dgvTransformed.AllowUserToAddRows = false;
         this.dgvTransformed.AllowUserToDeleteRows = false;
         this.dgvTransformed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvTransformed.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dgvTransformed.Location = new System.Drawing.Point(3, 318);
         this.dgvTransformed.Name = "dgvTransformed";
         this.dgvTransformed.ReadOnly = true;
         this.tableLayoutPanel1.SetRowSpan(this.dgvTransformed, 4);
         this.dgvTransformed.Size = new System.Drawing.Size(327, 91);
         this.dgvTransformed.TabIndex = 1;
         // 
         // txtAsciiUntransformedInfo
         // 
         this.txtAsciiUntransformedInfo.Location = new System.Drawing.Point(356, 109);
         this.txtAsciiUntransformedInfo.Name = "txtAsciiUntransformedInfo";
         this.txtAsciiUntransformedInfo.Size = new System.Drawing.Size(100, 66);
         this.txtAsciiUntransformedInfo.TabIndex = 2;
         this.txtAsciiUntransformedInfo.Text = "";
         // 
         // txtAsciiTransformedInfo
         // 
         this.txtAsciiTransformedInfo.Location = new System.Drawing.Point(356, 361);
         this.txtAsciiTransformedInfo.Name = "txtAsciiTransformedInfo";
         this.txtAsciiTransformedInfo.Size = new System.Drawing.Size(100, 36);
         this.txtAsciiTransformedInfo.TabIndex = 3;
         this.txtAsciiTransformedInfo.Text = "";
         // 
         // flowLayoutPanel1
         // 
         this.flowLayoutPanel1.Controls.Add(this.label1);
         this.flowLayoutPanel1.Controls.Add(this.txtTransformationFactor);
         this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.flowLayoutPanel1.Location = new System.Drawing.Point(356, 278);
         this.flowLayoutPanel1.Name = "flowLayoutPanel1";
         this.flowLayoutPanel1.Size = new System.Drawing.Size(327, 26);
         this.flowLayoutPanel1.TabIndex = 4;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(110, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Transformation Factor";
         // 
         // txtTransformationFactor
         // 
         this.txtTransformationFactor.Location = new System.Drawing.Point(119, 3);
         this.txtTransformationFactor.Mask = "00";
         this.txtTransformationFactor.Name = "txtTransformationFactor";
         this.txtTransformationFactor.Size = new System.Drawing.Size(56, 20);
         this.txtTransformationFactor.TabIndex = 1;
         this.txtTransformationFactor.Text = "01";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(356, 50);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(77, 13);
         this.label2.TabIndex = 5;
         this.label2.Text = "Transformation";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(356, 315);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(87, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "Retransformation";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(356, 85);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(25, 13);
         this.label4.TabIndex = 7;
         this.label4.Text = "Info";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(356, 334);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(25, 13);
         this.label5.TabIndex = 8;
         this.label5.Text = "Info";
         // 
         // CtrlAsciiView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "CtrlAsciiView";
         this.Size = new System.Drawing.Size(686, 436);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvUntransformed)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvTransformed)).EndInit();
         this.flowLayoutPanel1.ResumeLayout(false);
         this.flowLayoutPanel1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.DataGridView dgvUntransformed;
      private System.Windows.Forms.DataGridView dgvTransformed;
      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.MaskedTextBox txtTransformationFactor;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.RichTextBox txtAsciiUntransformedInfo;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.RichTextBox txtAsciiTransformedInfo;
      private System.Windows.Forms.Label label5;
   }
}
