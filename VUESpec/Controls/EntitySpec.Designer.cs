namespace VUESpec.Controls
{
    partial class EntitySpec
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
            this.EntitySpecDetails = new System.Windows.Forms.GroupBox();
            this.EntitySpecProperties = new System.Windows.Forms.PropertyGrid();
            this.BgMapSpec = new System.Windows.Forms.GroupBox();
            this.BgMapProperties = new System.Windows.Forms.PropertyGrid();
            this.TextureSpec = new System.Windows.Forms.GroupBox();
            this.TextureProperties = new System.Windows.Forms.PropertyGrid();
            this.CharSetSpec = new System.Windows.Forms.GroupBox();
            this.CharSetProperties = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EntitySpecDetails.SuspendLayout();
            this.BgMapSpec.SuspendLayout();
            this.TextureSpec.SuspendLayout();
            this.CharSetSpec.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntitySpecDetails
            // 
            this.EntitySpecDetails.Controls.Add(this.EntitySpecProperties);
            this.EntitySpecDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntitySpecDetails.Location = new System.Drawing.Point(213, 215);
            this.EntitySpecDetails.Name = "EntitySpecDetails";
            this.EntitySpecDetails.Size = new System.Drawing.Size(204, 207);
            this.EntitySpecDetails.TabIndex = 4;
            this.EntitySpecDetails.TabStop = false;
            this.EntitySpecDetails.Text = "Entity Spec";
            // 
            // EntitySpecProperties
            // 
            this.EntitySpecProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntitySpecProperties.Location = new System.Drawing.Point(3, 16);
            this.EntitySpecProperties.Name = "EntitySpecProperties";
            this.EntitySpecProperties.Size = new System.Drawing.Size(198, 188);
            this.EntitySpecProperties.TabIndex = 0;
            // 
            // BgMapSpec
            // 
            this.BgMapSpec.Controls.Add(this.BgMapProperties);
            this.BgMapSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BgMapSpec.Location = new System.Drawing.Point(3, 215);
            this.BgMapSpec.Name = "BgMapSpec";
            this.BgMapSpec.Size = new System.Drawing.Size(204, 207);
            this.BgMapSpec.TabIndex = 3;
            this.BgMapSpec.TabStop = false;
            this.BgMapSpec.Text = "BG Map Spec";
            // 
            // BgMapProperties
            // 
            this.BgMapProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BgMapProperties.Location = new System.Drawing.Point(3, 16);
            this.BgMapProperties.Name = "BgMapProperties";
            this.BgMapProperties.Size = new System.Drawing.Size(198, 188);
            this.BgMapProperties.TabIndex = 0;
            // 
            // TextureSpec
            // 
            this.TextureSpec.Controls.Add(this.TextureProperties);
            this.TextureSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextureSpec.Location = new System.Drawing.Point(213, 3);
            this.TextureSpec.Name = "TextureSpec";
            this.TextureSpec.Size = new System.Drawing.Size(204, 206);
            this.TextureSpec.TabIndex = 2;
            this.TextureSpec.TabStop = false;
            this.TextureSpec.Text = "Texture Spec";
            // 
            // TextureProperties
            // 
            this.TextureProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextureProperties.Location = new System.Drawing.Point(3, 16);
            this.TextureProperties.Name = "TextureProperties";
            this.TextureProperties.Size = new System.Drawing.Size(198, 187);
            this.TextureProperties.TabIndex = 0;
            // 
            // CharSetSpec
            // 
            this.CharSetSpec.Controls.Add(this.CharSetProperties);
            this.CharSetSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharSetSpec.Location = new System.Drawing.Point(3, 3);
            this.CharSetSpec.Name = "CharSetSpec";
            this.CharSetSpec.Size = new System.Drawing.Size(204, 206);
            this.CharSetSpec.TabIndex = 1;
            this.CharSetSpec.TabStop = false;
            this.CharSetSpec.Text = "Char Set Spec";
            // 
            // CharSetProperties
            // 
            this.CharSetProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharSetProperties.Location = new System.Drawing.Point(3, 16);
            this.CharSetProperties.Name = "CharSetProperties";
            this.CharSetProperties.Size = new System.Drawing.Size(198, 187);
            this.CharSetProperties.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CharSetSpec, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EntitySpecDetails, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextureSpec, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BgMapSpec, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 425);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // EntitySpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EntitySpec";
            this.Size = new System.Drawing.Size(420, 425);
            this.EntitySpecDetails.ResumeLayout(false);
            this.BgMapSpec.ResumeLayout(false);
            this.TextureSpec.ResumeLayout(false);
            this.CharSetSpec.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EntitySpecDetails;
        private System.Windows.Forms.PropertyGrid EntitySpecProperties;
        private System.Windows.Forms.GroupBox BgMapSpec;
        private System.Windows.Forms.PropertyGrid BgMapProperties;
        private System.Windows.Forms.GroupBox TextureSpec;
        private System.Windows.Forms.PropertyGrid TextureProperties;
        private System.Windows.Forms.GroupBox CharSetSpec;
        private System.Windows.Forms.PropertyGrid CharSetProperties;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
