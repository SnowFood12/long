using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm_DangKi
{
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
            trangchucon(); 
        }

        private void iBtn_NutThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool thuPhong = false;
        private void iBtn_PhongTo_Click(object sender, EventArgs e)
        {
            //Nút thu phóng
            if (thuPhong == false)
            {
                this.WindowState = FormWindowState.Maximized;
                thuPhong = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                thuPhong = false;
            }
        }

        private void iBtn_ThuNho_Click(object sender, EventArgs e)
        {
            //Nút thu về tabbar
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //Quay về form đăng nhập
            frm_DangNhap formDangNhap = new frm_DangNhap();
            formDangNhap.Show();
            this.Hide();
        }

        private void iBtn_SanPham_Click(object sender, EventArgs e)
        {
            frm_SanPham form1 = new frm_SanPham();
            form1.MdiParent = this;
            form1.Show();
            form1.Dock = DockStyle.Fill;
            lab_Content.Text = iBtn_SanPham.Text;
        }

        private void iBtn_Home_Click(object sender, EventArgs e)
        {
            frm_TrangChuCon form1 = new frm_TrangChuCon();
            form1.MdiParent = this;
            form1.Show();
            form1.Dock = DockStyle.Fill;
            lab_Content.Text = iBtn_Home.Text;
        }
        public void trangchucon()
        {
            frm_TrangChuCon form1 = new frm_TrangChuCon();
            form1.MdiParent = this;
            form1.Show();
            form1.Dock = DockStyle.Fill;
            lab_Content.Text = iBtn_Home.Text;
        }

        private void iBtn_DonHang_Click(object sender, EventArgs e)
        {
            // hiển thị trang đơn hàng 
            frm_DonHang form1 = new frm_DonHang();
            form1.MdiParent = this;
            form1.Show();
            form1.Dock = DockStyle.Fill;
            lab_Content.Text = iBtn_DonHang.Text;
        }

        private void iBtn_DoiTac_Click(object sender, EventArgs e)
        {
            frm_DoiTac form1 = new frm_DoiTac();
            form1.MdiParent = this;
            form1.Show();
            form1.Dock = DockStyle.Fill;
            lab_Content.Text = iBtn_DoiTac.Text;
        }

        private void iBtn_NhanVien_Click(object sender, EventArgs e)
        {
            frm_NhanVien form1 = new frm_NhanVien();
            form1.MdiParent = this;
            form1.Show();
            form1.Dock = DockStyle.Fill;
            lab_Content.Text = iBtn_NhanVien.Text;
        }

        private void iBtn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
