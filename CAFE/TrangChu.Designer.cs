namespace CAFE
{
    partial class Trangchu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSidebar = new System.Windows.Forms.PictureBox();
            this.btnCLose = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnDash = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnList = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnSup = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEmp = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCus = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.pnBills = new System.Windows.Forms.Panel();
            this.btnBill = new System.Windows.Forms.Button();
            this.pnTable = new System.Windows.Forms.Panel();
            this.btnTable = new System.Windows.Forms.Button();
            this.pnImport = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.menuTrans = new System.Windows.Forms.Timer(this.components);
            this.sidebarTrans = new System.Windows.Forms.Timer(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLose)).BeginInit();
            this.sideBar.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.pnDash.SuspendLayout();
            this.pnList.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnBills.SuspendLayout();
            this.pnTable.SuspendLayout();
            this.pnImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSidebar);
            this.panel1.Controls.Add(this.btnCLose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnSidebar
            // 
            this.btnSidebar.Image = global::CAFE.Properties.Resources.icons8_menu_32;
            this.btnSidebar.Location = new System.Drawing.Point(11, 3);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.Size = new System.Drawing.Size(40, 34);
            this.btnSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSidebar.TabIndex = 1;
            this.btnSidebar.TabStop = false;
            this.btnSidebar.Click += new System.EventHandler(this.btnSidebar_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.Image = global::CAFE.Properties.Resources.multiply_48px;
            this.btnCLose.Location = new System.Drawing.Point(951, 3);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(40, 34);
            this.btnCLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCLose.TabIndex = 9;
            this.btnCLose.TabStop = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sideBar.Controls.Add(this.pnHome);
            this.sideBar.Controls.Add(this.pnDash);
            this.sideBar.Controls.Add(this.pnList);
            this.sideBar.Controls.Add(this.pnBills);
            this.sideBar.Controls.Add(this.pnTable);
            this.sideBar.Controls.Add(this.pnImport);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 40);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(66, 535);
            this.sideBar.TabIndex = 1;
            this.sideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBar_Paint);
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.btnHome);
            this.pnHome.Location = new System.Drawing.Point(3, 3);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(200, 54);
            this.pnHome.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::CAFE.Properties.Resources.icons8_home_32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-7, -12);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(216, 77);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnDash
            // 
            this.pnDash.Controls.Add(this.btnDashboard);
            this.pnDash.Location = new System.Drawing.Point(3, 63);
            this.pnDash.Name = "pnDash";
            this.pnDash.Size = new System.Drawing.Size(200, 54);
            this.pnDash.TabIndex = 3;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::CAFE.Properties.Resources.icons8_statistics_32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-7, -12);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(216, 77);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Thống kê";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnList
            // 
            this.pnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pnList.Controls.Add(this.panel12);
            this.pnList.Controls.Add(this.panel6);
            this.pnList.Controls.Add(this.panel7);
            this.pnList.Controls.Add(this.panel5);
            this.pnList.Controls.Add(this.panel4);
            this.pnList.Location = new System.Drawing.Point(0, 120);
            this.pnList.Margin = new System.Windows.Forms.Padding(0);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(200, 46);
            this.pnList.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnSup);
            this.panel12.Location = new System.Drawing.Point(0, 222);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 54);
            this.panel12.TabIndex = 22;
            // 
            // btnSup
            // 
            this.btnSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnSup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSup.ForeColor = System.Drawing.Color.White;
            this.btnSup.Image = global::CAFE.Properties.Resources.icons8_supply_30;
            this.btnSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSup.Location = new System.Drawing.Point(-5, -12);
            this.btnSup.Margin = new System.Windows.Forms.Padding(0);
            this.btnSup.Name = "btnSup";
            this.btnSup.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSup.Size = new System.Drawing.Size(216, 77);
            this.btnSup.TabIndex = 3;
            this.btnSup.Text = "    Nhà cung cấp";
            this.btnSup.UseVisualStyleBackColor = false;
            this.btnSup.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnEmp);
            this.panel6.Location = new System.Drawing.Point(0, 172);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 54);
            this.panel6.TabIndex = 19;
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEmp.ForeColor = System.Drawing.Color.White;
            this.btnEmp.Image = global::CAFE.Properties.Resources.icons8_employee_50;
            this.btnEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmp.Location = new System.Drawing.Point(-7, -12);
            this.btnEmp.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmp.Size = new System.Drawing.Size(216, 77);
            this.btnEmp.TabIndex = 3;
            this.btnEmp.Text = "Nhân viên";
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnCus);
            this.panel7.Location = new System.Drawing.Point(0, 113);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 54);
            this.panel7.TabIndex = 16;
            // 
            // btnCus
            // 
            this.btnCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnCus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCus.ForeColor = System.Drawing.Color.White;
            this.btnCus.Image = global::CAFE.Properties.Resources.icons8_customer_50;
            this.btnCus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCus.Location = new System.Drawing.Point(-10, -12);
            this.btnCus.Margin = new System.Windows.Forms.Padding(0);
            this.btnCus.Name = "btnCus";
            this.btnCus.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCus.Size = new System.Drawing.Size(216, 77);
            this.btnCus.TabIndex = 3;
            this.btnCus.Text = "     Khách hàng";
            this.btnCus.UseVisualStyleBackColor = false;
            this.btnCus.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnProduct);
            this.panel5.Location = new System.Drawing.Point(3, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 54);
            this.panel5.TabIndex = 14;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::CAFE.Properties.Resources.icons8_coffee_48;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(-7, -12);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(216, 77);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnList);
            this.panel4.Location = new System.Drawing.Point(0, -4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 54);
            this.panel4.TabIndex = 4;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Image = global::CAFE.Properties.Resources.icons8_dropdown_30;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(-4, -12);
            this.btnList.Margin = new System.Windows.Forms.Padding(0);
            this.btnList.Name = "btnList";
            this.btnList.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnList.Size = new System.Drawing.Size(216, 77);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Danh mục";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.danhmuc_Click);
            // 
            // pnBills
            // 
            this.pnBills.Controls.Add(this.btnBill);
            this.pnBills.Location = new System.Drawing.Point(3, 169);
            this.pnBills.Name = "pnBills";
            this.pnBills.Size = new System.Drawing.Size(200, 54);
            this.pnBills.TabIndex = 5;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::CAFE.Properties.Resources.icons8_bill_30;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(-9, -12);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(216, 77);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "     Hóa đơn bán";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // pnTable
            // 
            this.pnTable.Controls.Add(this.btnTable);
            this.pnTable.Location = new System.Drawing.Point(3, 229);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(200, 54);
            this.pnTable.TabIndex = 4;
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Image = global::CAFE.Properties.Resources.icons8_restaurant_table_30;
            this.btnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Location = new System.Drawing.Point(-7, -12);
            this.btnTable.Name = "btnTable";
            this.btnTable.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTable.Size = new System.Drawing.Size(216, 77);
            this.btnTable.TabIndex = 3;
            this.btnTable.Text = "Bàn";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.button8_Click);
            // 
            // pnImport
            // 
            this.pnImport.Controls.Add(this.btnImport);
            this.pnImport.Location = new System.Drawing.Point(3, 289);
            this.pnImport.Name = "pnImport";
            this.pnImport.Size = new System.Drawing.Size(200, 54);
            this.pnImport.TabIndex = 4;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Image = global::CAFE.Properties.Resources.icons8_import_30;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(-7, -12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnImport.Size = new System.Drawing.Size(216, 77);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "     Hóa đơn nhập";
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // menuTrans
            // 
            this.menuTrans.Interval = 50;
            this.menuTrans.Tick += new System.EventHandler(this.menuTrans_Tick);
            // 
            // sidebarTrans
            // 
            this.sidebarTrans.Interval = 10;
            this.sidebarTrans.Tick += new System.EventHandler(this.sidebarTrans_Tick);
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(69, 41);
            this.pnMain.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(925, 534);
            this.pnMain.TabIndex = 2;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 575);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel1);
            this.Name = "Trangchu";
            this.Text = "Trang chủ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLose)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            this.pnDash.ResumeLayout(false);
            this.pnList.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnBills.ResumeLayout(false);
            this.pnTable.ResumeLayout(false);
            this.pnImport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSidebar;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnDash;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Timer menuTrans;
        private System.Windows.Forms.Panel pnImport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel pnBills;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Timer sidebarTrans;
        private System.Windows.Forms.Panel pnTable;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.PictureBox btnCLose;
        private System.Windows.Forms.Panel pnMain;
    }
}

