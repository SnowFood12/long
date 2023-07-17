using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace asm_DangKi
{
    public partial class frm_SanPham : Form
    {
        string str = "Data Source=.;Initial Catalog=WINFORM;Integrated Security=True";
        SqlConnection conn = null;
        public frm_SanPham()
        {
            InitializeComponent();

        }
        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        public void LoadDuLieu() 
        {
            conn = new SqlConnection(str);
            conn.Open();
            string query = "select * from SanPham"; 
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_DachSanPham.DataSource = dataTable;
            dgv_DachSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_DachSanPham.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
            conn.Close();
        } // load bảng
        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
            }
            catch (Exception ex) // bẫy lỗi khi không liên kết được với SQL 
            {
                MessageBox.Show("Lỗi " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                int SoLuong = int.Parse(txt_SoLuong.Text); 
                float GiaBan = float.Parse(txt_GiaTien.Text);

                // kiểm tra dữ liệu vào
                if (txt_MaSanPham.Text.Length < 5 || txt_MaSanPham.Text.Length > 8)
                {
                    MessageBox.Show("Mã sản phẩm không hợp lệ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txt_TenSanPham.Text.Length < 2)
                {
                    MessageBox.Show("Tên sản phẩm không hợp lệ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (SoLuong < 0 || GiaBan < 0)
                {
                    MessageBox.Show("Số lượng/Giá bán lớn hơn 0 !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //================================================================
                else
                {
                    try
                    {
                        // khai báo câu lệnh SQL
                        string query = $"INSERT INTO SanPham VALUES (@Ma, @Ten, @Gia , @SoLuong , @NgayNhapKho , @HanSuDung , @NgaySanXuat)";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        // gán giá trị cho câu lệnh
                        cmd.Parameters.AddWithValue("@Ma", txt_MaSanPham.Text);
                        cmd.Parameters.AddWithValue("@Ten", txt_TenSanPham.Text);
                        cmd.Parameters.AddWithValue("@Gia", txt_GiaTien.Text);
                        cmd.Parameters.AddWithValue("@SoLuong", txt_SoLuong.Text);
                        cmd.Parameters.AddWithValue("@NgayNhapKho", dtm_NgayNhapKho.Value.ToString("yyyy/MM/dd"));
                        cmd.Parameters.AddWithValue("@HanSuDung", dtm_HanSuDung.Value.ToString("yyyy/MM/dd"));
                        cmd.Parameters.AddWithValue("@NgaySanXuat", dtm_NgaySanXuat.Value.ToString("yyyy/MM/dd"));

                        // chạy câu lệnh SQL
                        cmd.ExecuteNonQuery();
                        LoadDuLieu(); // load lại dataview

                        // đóng kết nối SQL
                        conn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã sản phẩm không được trùng !!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FormatException) // bẫy lỗi khi nhập số lượng/giá bán không phải kí tự số 
            {
                MessageBox.Show("Số lượng/giá bán không hợp lệ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
