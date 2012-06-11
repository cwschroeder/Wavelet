namespace Wavelet.UI
{
   partial class CtrlGroupChartSubView
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
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
         System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
         System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.chartCxy = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.txtCurrentGroup = new System.Windows.Forms.TextBox();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.chartCxy)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 7;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Controls.Add(this.chartCxy, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.chart1, 4, 0);
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
         this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.txtCurrentGroup, 2, 2);
         this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 3;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 263);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // chartCxy
         // 
         chartArea1.Name = "ChartArea1";
         this.chartCxy.ChartAreas.Add(chartArea1);
         this.tableLayoutPanel1.SetColumnSpan(this.chartCxy, 3);
         this.chartCxy.Dock = System.Windows.Forms.DockStyle.Fill;
         legend1.Name = "Legend1";
         this.chartCxy.Legends.Add(legend1);
         this.chartCxy.Location = new System.Drawing.Point(3, 3);
         this.chartCxy.Name = "chartCxy";
         series1.ChartArea = "ChartArea1";
         series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
         series1.Legend = "Legend1";
         series1.Name = "Cxy";
         this.chartCxy.Series.Add(series1);
         this.chartCxy.Size = new System.Drawing.Size(417, 207);
         this.chartCxy.TabIndex = 2;
         this.chartCxy.Text = "chart2";
         // 
         // chart1
         // 
         chartArea2.Name = "ChartArea1";
         this.chart1.ChartAreas.Add(chartArea2);
         this.tableLayoutPanel1.SetColumnSpan(this.chart1, 3);
         this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
         legend2.Name = "Legend1";
         this.chart1.Legends.Add(legend2);
         this.chart1.Location = new System.Drawing.Point(446, 3);
         this.chart1.Name = "chart1";
         series2.ChartArea = "ChartArea1";
         series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
         series2.Legend = "Legend1";
         series2.Name = "Dxy";
         this.chart1.Series.Add(series2);
         this.chart1.Size = new System.Drawing.Size(417, 207);
         this.chart1.TabIndex = 3;
         this.chart1.Text = "chart1";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 213);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(57, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Last group";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(83, 213);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(59, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Next group";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(3, 236);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(74, 23);
         this.button1.TabIndex = 8;
         this.button1.Text = "<<";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(83, 236);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(74, 23);
         this.button2.TabIndex = 9;
         this.button2.Text = ">>";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.tableLayoutPanel1.SetColumnSpan(this.label3, 3);
         this.label3.Location = new System.Drawing.Point(163, 213);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(139, 13);
         this.label3.TabIndex = 10;
         this.label3.Text = "Current group / group count";
         // 
         // txtCurrentGroup
         // 
         this.txtCurrentGroup.Location = new System.Drawing.Point(163, 236);
         this.txtCurrentGroup.Name = "txtCurrentGroup";
         this.txtCurrentGroup.Size = new System.Drawing.Size(71, 20);
         this.txtCurrentGroup.TabIndex = 11;
         this.txtCurrentGroup.Text = "5/10";
         // 
         // CtrlGroupChartSubView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "CtrlGroupChartSubView";
         this.Size = new System.Drawing.Size(866, 263);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.chartCxy)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.DataVisualization.Charting.Chart chartCxy;
      private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtCurrentGroup;
   }
}
