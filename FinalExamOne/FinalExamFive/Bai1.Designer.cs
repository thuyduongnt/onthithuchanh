namespace FinalExamFive
{
    partial class Bai1
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnVe = new System.Windows.Forms.Button();
            this.lbketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số:";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(87, 10);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(100, 20);
            this.txtSo.TabIndex = 1;
            // 
            // btnVe
            // 
            this.btnVe.Location = new System.Drawing.Point(209, 9);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(75, 23);
            this.btnVe.TabIndex = 2;
            this.btnVe.Text = "Vẽ hình";
            this.btnVe.UseVisualStyleBackColor = true;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbketqua.Location = new System.Drawing.Point(179, 103);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(68, 18);
            this.lbketqua.TabIndex = 3;
            this.lbketqua.Text = "label2";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 282);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label1);
            this.Name = "Bai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.Label lbketqua;
    }
}