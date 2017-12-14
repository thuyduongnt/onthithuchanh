namespace ontap02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_hang = new System.Windows.Forms.TextBox();
            this.text_cot = new System.Windows.Forms.TextBox();
            this.btn_vehinh = new System.Windows.Forms.Button();
            this.lblketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số cột";
            // 
            // text_hang
            // 
            this.text_hang.Location = new System.Drawing.Point(191, 27);
            this.text_hang.Name = "text_hang";
            this.text_hang.Size = new System.Drawing.Size(128, 22);
            this.text_hang.TabIndex = 2;
            // 
            // text_cot
            // 
            this.text_cot.Location = new System.Drawing.Point(191, 73);
            this.text_cot.Name = "text_cot";
            this.text_cot.Size = new System.Drawing.Size(128, 22);
            this.text_cot.TabIndex = 3;
            // 
            // btn_vehinh
            // 
            this.btn_vehinh.Location = new System.Drawing.Point(354, 44);
            this.btn_vehinh.Name = "btn_vehinh";
            this.btn_vehinh.Size = new System.Drawing.Size(75, 33);
            this.btn_vehinh.TabIndex = 4;
            this.btn_vehinh.Text = "Tạo hình";
            this.btn_vehinh.UseVisualStyleBackColor = true;
            this.btn_vehinh.Click += new System.EventHandler(this.btn_vehinh_Click);
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(211, 156);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(13, 17);
            this.lblketqua.TabIndex = 5;
            this.lblketqua.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 496);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.btn_vehinh);
            this.Controls.Add(this.text_cot);
            this.Controls.Add(this.text_hang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_hang;
        private System.Windows.Forms.TextBox text_cot;
        private System.Windows.Forms.Button btn_vehinh;
        private System.Windows.Forms.Label lblketqua;
    }
}

