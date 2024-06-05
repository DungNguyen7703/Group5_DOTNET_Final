namespace CAFE
{
    partial class Baocao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BaocaoBan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BaocaoNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bCNhapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLCafeDataSet = new CAFE.QLCafeDataSet();
            this.BCNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCBanTableAdapter = new CAFE.QLCafeDataSetTableAdapters.BCBanTableAdapter();
            this.bCBanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bCNhapTableAdapter = new CAFE.QLCafeDataSetTableAdapters.BCNhapTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.BC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bCNhapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCBanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BC
            // 
            this.BC.Controls.Add(this.tabPage1);
            this.BC.Controls.Add(this.tabPage2);
            this.BC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BC.Location = new System.Drawing.Point(0, 0);
            this.BC.Name = "BC";
            this.BC.SelectedIndex = 0;
            this.BC.Size = new System.Drawing.Size(819, 461);
            this.BC.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.BaocaoBan);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo cáo Bán";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(346, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 25);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 25);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // BaocaoBan
            // 
            this.BaocaoBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BaocaoBan.LocalReport.ReportEmbeddedResource = "CAFE.Reports.BaocaoBan.rdlc";
            this.BaocaoBan.Location = new System.Drawing.Point(3, 135);
            this.BaocaoBan.Name = "BaocaoBan";
            this.BaocaoBan.ServerReport.BearerToken = null;
            this.BaocaoBan.Size = new System.Drawing.Size(805, 293);
            this.BaocaoBan.TabIndex = 0;
            this.BaocaoBan.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.BaocaoNhap);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(811, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Báo cáo Nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BaocaoNhap
            // 
            this.BaocaoNhap.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource3.Name = "BCNhap";
            reportDataSource3.Value = this.bCNhapBindingSource1;
            this.BaocaoNhap.LocalReport.DataSources.Add(reportDataSource3);
            this.BaocaoNhap.LocalReport.ReportEmbeddedResource = "CAFE.Reports.BaocaoNhap.rdlc";
            this.BaocaoNhap.Location = new System.Drawing.Point(3, 3);
            this.BaocaoNhap.Name = "BaocaoNhap";
            this.BaocaoNhap.ServerReport.BearerToken = null;
            this.BaocaoNhap.Size = new System.Drawing.Size(805, 286);
            this.BaocaoNhap.TabIndex = 4;
            this.BaocaoNhap.Load += new System.EventHandler(this.BaocaoNhap_Load);
            // 
            // button2
            // 
            this.button2.Image = global::CAFE.Properties.Resources.icons8_filter_30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(476, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "        Lọc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(295, 44);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(125, 25);
            this.dateTimePicker4.TabIndex = 2;
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(98, 44);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(125, 25);
            this.dateTimePicker3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.dateTimePicker4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 139);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 100);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn ngày để xem thống kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đến ngày";
            // 
            // button1
            // 
            this.button1.Image = global::CAFE.Properties.Resources.icons8_filter_30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(535, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "        Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCNhapBindingSource1
            // 
            this.bCNhapBindingSource1.DataMember = "BCNhap";
            this.bCNhapBindingSource1.DataSource = this.qLCafeDataSet;
            // 
            // qLCafeDataSet
            // 
            this.qLCafeDataSet.DataSetName = "QLCafeDataSet";
            this.qLCafeDataSet.EnforceConstraints = false;
            this.qLCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BCNhapBindingSource
            // 
            this.BCNhapBindingSource.DataMember = "BCNhap";
            this.BCNhapBindingSource.DataSource = this.qLCafeDataSet;
            // 
            // bCBanBindingSource
            // 
            this.bCBanBindingSource.DataMember = "BCBan";
            this.bCBanBindingSource.DataSource = this.qLCafeDataSet;
            // 
            // bCBanTableAdapter
            // 
            this.bCBanTableAdapter.ClearBeforeFill = true;
            // 
            // bCBanBindingSource1
            // 
            this.bCBanBindingSource1.DataMember = "BCBan";
            this.bCBanBindingSource1.DataSource = this.qLCafeDataSet;
            // 
            // bCNhapTableAdapter
            // 
            this.bCNhapTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chọn ngày để xem thống kê";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 461);
            this.Controls.Add(this.BC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Baocao";
            this.Text = "Baocao";
            this.Load += new System.EventHandler(this.Baocao_Load);
            this.BC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bCNhapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCBanBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl BC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer BaocaoBan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private QLCafeDataSet qLCafeDataSet;
        private System.Windows.Forms.BindingSource bCBanBindingSource;
        private QLCafeDataSetTableAdapters.BCBanTableAdapter bCBanTableAdapter;
        private System.Windows.Forms.BindingSource bCBanBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private Microsoft.Reporting.WinForms.ReportViewer BaocaoNhap;
        private System.Windows.Forms.BindingSource BCNhapBindingSource;
        private System.Windows.Forms.BindingSource bCNhapBindingSource1;
        private QLCafeDataSetTableAdapters.BCNhapTableAdapter bCNhapTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}