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
    }
}
