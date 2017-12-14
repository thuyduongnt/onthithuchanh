namespace ontap01
{
    partial class Form1
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
            this.text_nhap = new System.Windows.Forms.TextBox();
            this.text_xuat = new System.Windows.Forms.TextBox();
            this.check_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_nhap
            // 
            this.text_nhap.Location = new System.Drawing.Point(198, 49);
            this.text_nhap.Multiline = true;
            this.text_nhap.Name = "text_nhap";
            this.text_nhap.Size = new System.Drawing.Size(201, 44);
            this.text_nhap.TabIndex = 0;
            // 
            // text_xuat
            // 
            this.text_xuat.Location = new System.Drawing.Point(198, 122);
            this.text_xuat.Multiline = true;
            this.text_xuat.Name = "text_xuat";
            this.text_xuat.Size = new System.Drawing.Size(201, 42);
            this.text_xuat.TabIndex = 1;
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(445, 60);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 23);
            this.check_btn.TabIndex = 2;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Các số nguyên tố";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.text_xuat);
            this.Controls.Add(this.text_nhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nhap;
        private System.Windows.Forms.TextBox text_xuat;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

