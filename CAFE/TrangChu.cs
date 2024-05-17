using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAFE.CLass;

namespace CAFE
{
    public partial class Trangchu : Form
    {
        bool menuExpand = false;
        bool sidebarExpand = false;
        public Trangchu()
        {
            InitializeComponent();

        }

        private void menuTrans_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                pnList.Height += 10;
                if (pnList.Height >= 282)
                {
                    menuTrans.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                pnList.Height -= 10;
                if (pnList.Height <= 54)
                {
                    menuTrans.Stop();
                    menuExpand = false;
                }
            }
        }

        private void danhmuc_Click(object sender, EventArgs e)
        {
            menuTrans.Start();
        }

        private void sidebarTrans_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 65)
                {
                    sidebarTrans.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 208)
                {
                    sidebarTrans.Stop();
                    sidebarExpand = true;
                }
/*                pnHome.Width= pnDash.Width = pnList.Width = pnImport.Width = pnBills.Width = pnTable.Width = sideBar.Width;
*/            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nhanvien nhanvien = new Nhanvien();
            nhanvien.Owner = this;
            nhanvien.Show();
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTrans.Start();   
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            HoadonBan hoadonBan = new HoadonBan();
            hoadonBan.TopLevel = false;
            /*hoadonBan.FormBorderStyle = FormBorderStyle.None;*/
            hoadonBan.Dock = DockStyle.Fill;
            pnMain.Controls.Add(hoadonBan);
            hoadonBan.Show();
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {
            sideBar.BringToFront();
        }
    }
}
