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
<<<<<<< HEAD
        string connString = "Data Source=LPL\\LONGPOLY;Initial Catalog=SNOWFOOD;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private DataTable table;

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            // Lấy danh sách tình trạng sản phẩm từ cơ sở dữ liệu vào comboBox
            string query = "SELECT DISTINCT TinhTrang FROM SanPham";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbo_TinhTrang.Items.Add(reader["TinhTrang"].ToString()); 
                        }
                    }
                }
            }
            
        }
        private void FilterByTinhTrang()
        {
            // Lấy giá trị được chọn trong ComboBox cbo_TinhTrang
            string selectedTinhTrang = cbo_TinhTrang.SelectedItem.ToString();

            // Tạo câu truy vấn SQL để lọc dữ liệu từ bảng SanPham dựa trên giá trị được chọn trong ComboBox
            string query = "SELECT * FROM SanPham WHERE TinhTrang = N'" + selectedTinhTrang + "'";

            // Thực hiện truy vấn SQL và lấy dữ liệu vào DataTable
            using (SqlConnection conn = new SqlConnection(connString))
            {
                dataAdapter = new SqlDataAdapter(query, conn);
                table = new DataTable();
                dataAdapter.Fill(table);
            }

            // Hiển thị dữ liệu lọc lên DataGridView
            dagv_DSSanPham.DataSource = table;
        }

        private void btn_LocHSD_Click(object sender, EventArgs e)
        {
            FilterByTinhTrang();
        }

        private void btn_XemSP_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các sản phẩm còn tốt nhưng thời gian sử dụng đã hết
            string query = "SELECT * FROM SanPham WHERE TinhTrang = N'Còn tốt' AND HanSuDung < GETDATE()";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                dataAdapter = new SqlDataAdapter(query, conn);
                table = new DataTable();
                dataAdapter.Fill(table);
            }

            // Hiển thị danh sách sản phẩm lên DataGridView
            dagv_DSSanPham.DataSource = table;

            // Cho phép chỉnh sửa tình trạng của các sản phẩm có thời gian sử dụng đã hết
            dagv_DSSanPham.Columns["TinhTrang"].ReadOnly = false;
        }

        private void btn_LuuTTSP_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các sản phẩm có tình trạng đã thay đổi từ DataGridView
            DataTable changedTable = table.GetChanges();
            if (changedTable != null)
            {
                foreach (DataRow row in changedTable.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        string maSP = row["MaSanPham"].ToString();
                        string tinhTrang = row["TinhTrang"].ToString();
                        string ghiChu = row["GhiChu"].ToString();
                        string query = "UPDATE SanPham SET TinhTrang = @TinhTrang, GhiChu = @GhiChu WHERE MaSanPham = @MaSanPham";
                        using (SqlConnection conn = new SqlConnection(connString))
                        {
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                            cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                            cmd.Parameters.AddWithValue("@MaSanPham", maSP);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }

            // Hiển thị lại danh sách sản phẩm lên DataGridView
            dagv_DSSanPham.DataSource = table;
        }

        private void btn_LoaiBo_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách các sản phẩm còn tốt nhưng thời gian sử dụng đã hết
                string query = "SELECT * FROM SanPham WHERE HanSuDung < GETDATE()";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    dataAdapter = new SqlDataAdapter(query, conn);
                    table = new DataTable();
                    dataAdapter.Fill(table);

                    // Xoá các sản phẩm hết hạn khỏi cơ sở dữ liệu
                    SqlCommand cmd = new SqlCommand("DELETE FROM SanPham WHERE HanSuDung < GETDATE()", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                // Cho phép chỉnh sửa tình trạng của các sản phẩm có thời gian sử dụng đã hết
                dagv_DSSanPham.Columns["TinhTrang"].ReadOnly = false;
                // Hiển thị danh sách sản phẩm lên DataGridView
                dagv_DSSanPham.DataSource = table;
            }
            catch (SqlException ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Không thể xoá sản phẩm đã hết hạn do lỗi: " + ex.Message);
            }
        }

        private void btn_TatCaSP_Click(object sender, EventArgs e)
        {
            // Kết nối với cơ sở dữ liệu và lấy danh sách sản phẩm
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM SanPham", conn);
                table = new DataTable();
                dataAdapter.Fill(table);
            }
            // Đưa thông tin sản phẩm vào DataGridView
            dagv_DSSanPham.DataSource = table;
            // Tự động chỉnh độ rộng các cột dựa trên nội dung của các ô dữ liệu
            foreach (DataGridViewColumn column in dagv_DSSanPham.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            // Đặt thuộc tính ReadOnly cho cac cot
            dagv_DSSanPham.Columns["MaSanPham"].ReadOnly = true;
            dagv_DSSanPham.Columns["TenSanPham"].ReadOnly = true;
            dagv_DSSanPham.Columns["TinhTrang"].ReadOnly = true;
            dagv_DSSanPham.Columns["GiaBan"].ReadOnly = true;
            dagv_DSSanPham.Columns["SoLuong"].ReadOnly = true;
            dagv_DSSanPham.Columns["NgayNhapKho"].ReadOnly = true;
            dagv_DSSanPham.Columns["NgaySanXuat"].ReadOnly = true;
            dagv_DSSanPham.Columns["HanSuDung"].ReadOnly = true;
            dagv_DSSanPham.Columns["GhiChu"].ReadOnly = false;
        }
=======
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
        } 
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


>>>>>>> nhanh1
    }
}
