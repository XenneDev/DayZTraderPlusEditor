namespace DayZ_TraderPlus_Editor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTraderConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTraderConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(1384, 28);
            this.MainFormMenuStrip.TabIndex = 1;
            this.MainFormMenuStrip.Text = "MainFormMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTraderConfigToolStripMenuItem,
            this.openTraderConfigToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.closToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newTraderConfigToolStripMenuItem
            // 
            this.newTraderConfigToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newTraderConfigToolStripMenuItem.Image")));
            this.newTraderConfigToolStripMenuItem.Name = "newTraderConfigToolStripMenuItem";
            this.newTraderConfigToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newTraderConfigToolStripMenuItem.Text = "&New TraderConfig";
            this.newTraderConfigToolStripMenuItem.Click += new System.EventHandler(this.newTraderConfigToolStripMenuItem_Click);
            // 
            // openTraderConfigToolStripMenuItem
            // 
            this.openTraderConfigToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openTraderConfigToolStripMenuItem.Image")));
            this.openTraderConfigToolStripMenuItem.Name = "openTraderConfigToolStripMenuItem";
            this.openTraderConfigToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openTraderConfigToolStripMenuItem.Text = "&Open TraderConfig";
            this.openTraderConfigToolStripMenuItem.Click += new System.EventHandler(this.openTraderConfigToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // closToolStripMenuItem
            // 
            this.closToolStripMenuItem.Name = "closToolStripMenuItem";
            this.closToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.closToolStripMenuItem.Text = "&Close";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 615);
            this.Controls.Add(this.MainFormMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "DayZ TraderPlus Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTraderConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTraderConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closToolStripMenuItem;
    }
}

