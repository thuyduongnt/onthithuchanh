namespace FinalExamOne
{
    partial class ThongKe
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.nbNam = new System.Windows.Forms.NumericUpDown();
            this.view_TheodoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new FinalExamOne.DataSet1();
            this.view_TheodoiTableAdapter = new FinalExamOne.DataSet1TableAdapters.view_TheodoiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nbNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TheodoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_TheodoiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalExamOne.rpTheodoi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(831, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm:";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(221, 10);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // nbNam
            // 
            this.nbNam.Location = new System.Drawing.Point(78, 11);
            this.nbNam.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbNam.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nbNam.Name = "nbNam";
            this.nbNam.Size = new System.Drawing.Size(120, 22);
            this.nbNam.TabIndex = 4;
            this.nbNam.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // view_TheodoiBindingSource
            // 
            this.view_TheodoiBindingSource.DataMember = "view_Theodoi";
            this.view_TheodoiBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_TheodoiTableAdapter
            // 
            this.view_TheodoiTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 427);
            this.Controls.Add(this.nbNam);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TheodoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.NumericUpDown nbNam;
        private System.Windows.Forms.BindingSource view_TheodoiBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.view_TheodoiTableAdapter view_TheodoiTableAdapter;
    }
}