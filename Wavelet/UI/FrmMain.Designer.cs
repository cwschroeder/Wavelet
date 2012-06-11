namespace Wavelet
{
   partial class FrmMain
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.menuMain = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.statusMain = new System.Windows.Forms.StatusStrip();
         this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
         this.tabCtrlMain = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.tabPage4 = new System.Windows.Forms.TabPage();
         this.ctrlFileView1 = new Wavelet.UI.CtrlFileView();
         this.ctrlRawdataView1 = new Wavelet.UI.CtrlRawdataView();
         this.ctrlTransformView1 = new Wavelet.UI.CtrlTransformView();
         this.ctrlAsciiView1 = new Wavelet.UI.CtrlAsciiView();
         this.menuMain.SuspendLayout();
         this.statusMain.SuspendLayout();
         this.tabCtrlMain.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.tabPage3.SuspendLayout();
         this.tabPage4.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuMain
         // 
         this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
         this.menuMain.Location = new System.Drawing.Point(0, 0);
         this.menuMain.Name = "menuMain";
         this.menuMain.Size = new System.Drawing.Size(1264, 24);
         this.menuMain.TabIndex = 0;
         this.menuMain.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.logToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // settingsToolStripMenuItem
         // 
         this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
         this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
         this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
         this.settingsToolStripMenuItem.Text = "Settings";
         // 
         // loadToolStripMenuItem
         // 
         this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
         this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
         this.loadToolStripMenuItem.Text = "Load";
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
         this.saveToolStripMenuItem.Text = "Save";
         // 
         // logToolStripMenuItem
         // 
         this.logToolStripMenuItem.Name = "logToolStripMenuItem";
         this.logToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
         this.logToolStripMenuItem.Text = "Log";
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.aboutToolStripMenuItem});
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
         this.toolStripMenuItem1.Text = "?";
         // 
         // infoToolStripMenuItem
         // 
         this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
         this.infoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
         this.infoToolStripMenuItem.Text = "Info";
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
         this.aboutToolStripMenuItem.Text = "About";
         // 
         // statusMain
         // 
         this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
         this.statusMain.Location = new System.Drawing.Point(0, 775);
         this.statusMain.Name = "statusMain";
         this.statusMain.Size = new System.Drawing.Size(1264, 22);
         this.statusMain.TabIndex = 1;
         this.statusMain.Text = "statusStrip1";
         // 
         // lblStatus
         // 
         this.lblStatus.Name = "lblStatus";
         this.lblStatus.Size = new System.Drawing.Size(61, 17);
         this.lblStatus.Text = "Status: OK";
         // 
         // tabCtrlMain
         // 
         this.tabCtrlMain.Controls.Add(this.tabPage1);
         this.tabCtrlMain.Controls.Add(this.tabPage2);
         this.tabCtrlMain.Controls.Add(this.tabPage3);
         this.tabCtrlMain.Controls.Add(this.tabPage4);
         this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabCtrlMain.Location = new System.Drawing.Point(0, 24);
         this.tabCtrlMain.Name = "tabCtrlMain";
         this.tabCtrlMain.SelectedIndex = 0;
         this.tabCtrlMain.Size = new System.Drawing.Size(1264, 751);
         this.tabCtrlMain.TabIndex = 2;
         this.tabCtrlMain.SelectedIndexChanged += new System.EventHandler(this.tabCtrlMain_SelectedIndexChanged);
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.ctrlFileView1);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(1256, 725);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Files";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.ctrlRawdataView1);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(1256, 725);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Raw Data";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // tabPage3
         // 
         this.tabPage3.Controls.Add(this.ctrlAsciiView1);
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Size = new System.Drawing.Size(1256, 725);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "ASCII";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // tabPage4
         // 
         this.tabPage4.Controls.Add(this.ctrlTransformView1);
         this.tabPage4.Location = new System.Drawing.Point(4, 22);
         this.tabPage4.Name = "tabPage4";
         this.tabPage4.Size = new System.Drawing.Size(1256, 725);
         this.tabPage4.TabIndex = 3;
         this.tabPage4.Text = "Single Step";
         this.tabPage4.UseVisualStyleBackColor = true;
         // 
         // ctrlFileView1
         // 
         this.ctrlFileView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ctrlFileView1.Location = new System.Drawing.Point(3, 3);
         this.ctrlFileView1.Name = "ctrlFileView1";
         this.ctrlFileView1.Size = new System.Drawing.Size(1250, 719);
         this.ctrlFileView1.TabIndex = 0;
         // 
         // ctrlRawdataView1
         // 
         this.ctrlRawdataView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ctrlRawdataView1.Location = new System.Drawing.Point(3, 3);
         this.ctrlRawdataView1.Name = "ctrlRawdataView1";
         this.ctrlRawdataView1.Size = new System.Drawing.Size(1250, 719);
         this.ctrlRawdataView1.TabIndex = 0;
         // 
         // ctrlTransformView1
         // 
         this.ctrlTransformView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ctrlTransformView1.Location = new System.Drawing.Point(0, 0);
         this.ctrlTransformView1.Name = "ctrlTransformView1";
         this.ctrlTransformView1.Size = new System.Drawing.Size(1256, 725);
         this.ctrlTransformView1.TabIndex = 0;
         // 
         // ctrlAsciiView1
         // 
         this.ctrlAsciiView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ctrlAsciiView1.Location = new System.Drawing.Point(0, 0);
         this.ctrlAsciiView1.Name = "ctrlAsciiView1";
         this.ctrlAsciiView1.Size = new System.Drawing.Size(1256, 725);
         this.ctrlAsciiView1.TabIndex = 0;
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1264, 797);
         this.Controls.Add(this.tabCtrlMain);
         this.Controls.Add(this.statusMain);
         this.Controls.Add(this.menuMain);
         this.Name = "FrmMain";
         this.Text = "Wavelet App";
         this.menuMain.ResumeLayout(false);
         this.menuMain.PerformLayout();
         this.statusMain.ResumeLayout(false);
         this.statusMain.PerformLayout();
         this.tabCtrlMain.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage2.ResumeLayout(false);
         this.tabPage3.ResumeLayout(false);
         this.tabPage4.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuMain;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.StatusStrip statusMain;
      private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
      private System.Windows.Forms.ToolStripStatusLabel lblStatus;
      private System.Windows.Forms.TabControl tabCtrlMain;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.TabPage tabPage4;
      private UI.CtrlFileView ctrlFileView1;
      private UI.CtrlRawdataView ctrlRawdataView1;
      private UI.CtrlTransformView ctrlTransformView1;
      private UI.CtrlAsciiView ctrlAsciiView1;
   }
}

