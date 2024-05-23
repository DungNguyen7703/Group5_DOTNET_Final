using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        Trangchu trangchu;
        Nhanvien nv;
        Khachhang kh;
        Sanpham sp;
        Hoadon hoadon;
        Timkiem Timkiem;
        Baocao Baocao;

        public Trangchu()
        {
            InitializeComponent();
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private void menuTrans_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                pnList.Height += 20;
                if (pnList.Height >= 276)
                {
                    menuTrans.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                pnList.Height -= 20;
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
                sideBar.Width -= 5;
                if (sideBar.Width <= 65)
                {
                    sidebarTrans.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                sideBar.Width += 5;
                if (sideBar.Width >= 208)
                {
                    sidebarTrans.Stop();
                    sidebarExpand = true;
                }
                /*                pnHome.Width= pnDash.Width = pnList.Width = pnImport.Width = pnBills.Width = pnTable.Width = sideBar.Width;
                */
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nv == null)
            {
                nv = new Nhanvien();
                nv.FormClosed += Nhanvien_FormClosed;
                nv.MdiParent = this;
                nv.Dock = DockStyle.Fill;
                nv.Show();
            }
            else
            {
                nv.Activate();
            }
        }

        private void Nhanvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            nv = null;
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTrans.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sp == null)
            {
                sp = new Sanpham();
                sp.FormClosed += Sp_FormClosed;
                sp.MdiParent = this;
                sp.Dock = DockStyle.Fill;
                sp.Show();
            }
            else
            {
                sp.Activate();
            }
        }

        private void Sp_FormClosed(object sender, FormClosedEventArgs e)
        {
            sp = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (kh == null)
            {
                kh = new Khachhang();
                kh.FormClosed += Kh_FormClosed;
                kh.MdiParent = this;
                kh.Dock = DockStyle.Fill;
                ActiveMdiChild.Close();
                kh.Show();
            }
            else
            {
                kh.Activate();
            }
        }

        private void Kh_FormClosed(object sender, FormClosedEventArgs e)
        {
            kh = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (nv == null)
            {
                nv = new Nhanvien();
                nv.FormClosed += Nhanvien_FormClosed;
                nv.MdiParent = this;
                nv.Dock = DockStyle.Fill;
                nv.Show();
            }
            else
            {
                nv.Activate();
            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            /*            if (trangchu == null)
                        {
                            trangchu = new Trangchu();
                            trangchu.FormClosed += Trangchu_FormClosed;
                            trangchu.MdiParent = trangchu;
                            trangchu.Show();
                        }
                        else
                        {
                            trangchu.Activate();
                        }*/
        }

        private void Trangchu_FormClosed(object sender, FormClosedEventArgs e)
        {
            trangchu = null;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (hoadon == null)
            {
                hoadon = new Hoadon();
                hoadon.FormClosed += HoadonFormClosed;
                hoadon.MdiParent = this;
                hoadon.Dock = DockStyle.Fill;
                hoadon.Show();

            }
            else
            {
                hoadon.Activate();
            }
        }

        private void HoadonFormClosed(object sender, FormClosedEventArgs e)
        {
            hoadon = null;
        }

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {
            sideBar.BringToFront();
        }




        private void Trangchu_Load(object sender, EventArgs e)
        {

        }


        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (Timkiem == null)
            {
                Timkiem = new Timkiem();
                Timkiem.FormClosed += Timkiem_FormClosed;
                Timkiem.MdiParent = this;
                Timkiem.Dock = DockStyle.Fill;
                Timkiem.Show();
            }
            else
            {
                Timkiem.Activate();
            }
        }

        private void Timkiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Timkiem = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bthbaocaonhap_Click(object sender, EventArgs e)
        {
            if (Baocao == null)
            {
                Baocao = new Baocao();
                Baocao.FormClosed += Baocao_FormClosed;
                Baocao.MdiParent = this;
                Baocao.Dock = DockStyle.Fill;
                Baocao.Show();
            }
            else
            {
                Baocao.Activate();
            }
        }

        private void Baocao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Baocao = null;
        }
    }
}
