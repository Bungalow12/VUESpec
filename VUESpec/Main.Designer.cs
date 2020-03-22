namespace VUESpec
{
    partial class Main
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.OpenImage = new System.Windows.Forms.OpenFileDialog();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkspaceAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entitySpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderSpecsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Location = new System.Drawing.Point(12, 27);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(776, 411);
            this.Tabs.TabIndex = 0;
            // 
            // OpenImage
            // 
            this.OpenImage.DefaultExt = "*.png";
            this.OpenImage.Filter = "PNG files|*.png|Bitmap files|*.bmp|All files |*.*";
            this.OpenImage.Title = "Open Image";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.buildToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveWorkspaceToolStripMenuItem,
            this.saveWorkspaceAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addSpecToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // saveWorkspaceToolStripMenuItem
            // 
            this.saveWorkspaceToolStripMenuItem.Name = "saveWorkspaceToolStripMenuItem";
            this.saveWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveWorkspaceToolStripMenuItem.Text = "&Save Workspace";
            // 
            // saveWorkspaceAsToolStripMenuItem
            // 
            this.saveWorkspaceAsToolStripMenuItem.Name = "saveWorkspaceAsToolStripMenuItem";
            this.saveWorkspaceAsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveWorkspaceAsToolStripMenuItem.Text = "Save Workspace &As...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // addSpecToolStripMenuItem
            // 
            this.addSpecToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entitySpecToolStripMenuItem});
            this.addSpecToolStripMenuItem.Name = "addSpecToolStripMenuItem";
            this.addSpecToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addSpecToolStripMenuItem.Text = "A&dd Spec";
            // 
            // entitySpecToolStripMenuItem
            // 
            this.entitySpecToolStripMenuItem.Name = "entitySpecToolStripMenuItem";
            this.entitySpecToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entitySpecToolStripMenuItem.Text = "Entit&y Spec";
            this.entitySpecToolStripMenuItem.Click += new System.EventHandler(this.entitySpecToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renderSpecsToolStripMenuItem});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.buildToolStripMenuItem.Text = "&Build";
            // 
            // renderSpecsToolStripMenuItem
            // 
            this.renderSpecsToolStripMenuItem.Name = "renderSpecsToolStripMenuItem";
            this.renderSpecsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renderSpecsToolStripMenuItem.Text = "&Render Specs";
            this.renderSpecsToolStripMenuItem.Click += new System.EventHandler(this.renderSpecsToolStripMenuItem_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.MainMenu);
            this.Name = "Main";
            this.Text = "VUESpec";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.OpenFileDialog OpenImage;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorkspaceAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addSpecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entitySpecToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderSpecsToolStripMenuItem;
    }
}