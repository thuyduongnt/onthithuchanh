namespace FinalExamOne
{
    partial class HeThong
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
            this.menuLogin = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiCôngViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLogin
            // 
            this.menuLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.loạiCôngViệcToolStripMenuItem,
            this.côngViệcToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuLogin.Location = new System.Drawing.Point(0, 0);
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(452, 24);
            this.menuLogin.TabIndex = 0;
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // loạiCôngViệcToolStripMenuItem
            // 
            this.loạiCôngViệcToolStripMenuItem.Name = "loạiCôngViệcToolStripMenuItem";
            this.loạiCôngViệcToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.loạiCôngViệcToolStripMenuItem.Text = "Loại Công Việc";
            this.loạiCôngViệcToolStripMenuItem.Click += new System.EventHandler(this.loạiCôngViệcToolStripMenuItem_Click);
            // 
            // côngViệcToolStripMenuItem
            // 
            this.côngViệcToolStripMenuItem.Name = "côngViệcToolStripMenuItem";
            this.côngViệcToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.côngViệcToolStripMenuItem.Text = "Công Việc";
            this.côngViệcToolStripMenuItem.Click += new System.EventHandler(this.côngViệcToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sinh viên: Nguyễn Thị Thùy Dương - 1381310020 - D8CNPM";
            // 
            // HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuLogin);
            this.MainMenuStrip = this.menuLogin;
            this.Name = "HeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống";
            this.menuLogin.ResumeLayout(false);
            this.menuLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuLogin;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiCôngViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

