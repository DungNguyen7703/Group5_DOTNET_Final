using CAFE.CLass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE
{
    public partial class frmTimkiem : Form
    {
        public frmTimkiem()
        {
            InitializeComponent();
        }

        private void Timkiem_Load(object sender, EventArgs e)
        {
            CLass.Functions.ketnoi();
            txtMasanpham.Enabled = false;
            CLass.Functions.fillcombo("select MaLoai, TenLoai from Loai", cboMaloai, "MaLoai", "TenLoai");
            cboMaloai.SelectedIndex = -1;
            //CLass.Functions.fillcombo("select Macongdung, Congdung from Congdung", cboMacongdung, "MaCongdung", "TenLoai");
            //cboMaloai.SelectedIndex = -1;
            Load_dgridSanpham();
            ResetValues();
            dgridSanpham.DataSource = null;
        }
        private void dgridSanpham_Click(object sender, EventArgs e)
        {
           
            txtMasanpham.Text = dgridSanpham.CurrentRow.Cells["MaSanPham"].Value.ToString();
            txtTensanpham.Text = dgridSanpham.CurrentRow.Cells["TenSanPham"].Value.ToString();

            string ma;
            ma = dgridSanpham.CurrentRow.Cells["MaLoai"].Value.ToString();
            cboMaloai.Text = CLass.Functions.getfieldvalues("select TenLoai from Loai where MaLoai=N'" + ma + "'");

            txtSoluong.Text = dgridSanpham.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDongiaban.Text = dgridSanpham.CurrentRow.Cells["GiaBan"].Value.ToString();
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMasanpham.Focus();
        }
        private DataTable Sanpham;
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMasanpham.Text == "") && (txtTensanpham.Text == "") && (cboMaloai.Text == "") && (cboMacongdung.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM SanPham WHERE 1=1";
            if (txtMasanpham.Text != "")
                sql = sql + " AND MaSanPham Like N'%" + txtMasanpham.Text + "%'";
            if (txtTensanpham.Text != "")
                sql = sql + " AND TenSanPham Like N'%" + txtTensanpham.Text + "%'";
            if (cboMaloai.Text != "")
                sql = sql + " AND MaLoai Like N'%" + cboMaloai.SelectedValue + "%'";
            if (cboMacongdung.Text != "")
                sql = sql + " AND MaCongDung Like N'%" + cboMacongdung.SelectedValue + "%'";
            Sanpham = Functions.GetDataTable(sql);
            if (Sanpham.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + Sanpham.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgridSanpham.DataSource = Sanpham;
            ResetValues();
        }
        DataTable QLCafe;
        private void Load_dgridSanpham()
        {
            string sql;
            sql = "select MaSanPham, TenSanPham, MaLoai, SoLuong, GiaBan from SanPham";
            QLCafe = CLass.Functions.GetDataTable(sql);
            dgridSanpham.DataSource = QLCafe;
            dgridSanpham.Columns[0].HeaderText = "Mã sản phẩm";
            dgridSanpham.Columns[1].HeaderText = "Tên sản phẩm";
            dgridSanpham.Columns[2].HeaderText = "Mã loại";
            dgridSanpham.Columns[3].HeaderText = "Số lượng";
            //dgridSanpham.Columns[4].HeaderText = "Giá nhập";
            dgridSanpham.Columns[4].HeaderText = "Giá bán";
            //dgridSanpham.Columns[6].HeaderText = "Mã công dụng";
            dgridSanpham.AllowUserToAddRows = false;
            dgridSanpham.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgridSanpham.DataSource = null;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgirdSanpham_DoubleClick(object sender, EventArgs e)
        {
            string masp;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                masp = dgridSanpham.CurrentRow.Cells["MaSanPham"].Value.ToString();
                frmTimkiem frm = new frmTimkiem();
                frm.txtMasanpham.Text = masp;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }
    }
}
