using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class HumanResourceAdminForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BQ49Q1R;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Encrypt=False";
        private string username;

        public HumanResourceAdminForm(string username)
        {
            InitializeComponent();
            this.username = username;
            this.FormClosing += HumanResourceUserForm_FormClosing;
            this.Load += HumanResourceUserForm_Load;
        }

        private void HumanResourceUserForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Gọi stored procedure để lấy thông tin tất cả nhân viên ngoại trừ nhân viên trong phòng ban của người dùng
                    using (SqlCommand command = new SqlCommand("GetAllEmployees", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TenDangNhap", username);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void HumanResourceUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu đóng cửa sổ là do người dùng nhấn nút đóng
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Đóng tất cả các cửa sổ và thoát chương trình
                Application.Exit();
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox trên form
            int maSo = Convert.ToInt32(txt_MaSo.Text);
            string ten = txt_Ten.Text;
            DateTime ngaySinh = Convert.ToDateTime(txt_NgaySinh.Text);
            string email = txt_Email.Text;
            string phongBan = txt_PhongBan.Text;
            decimal luong = Convert.ToDecimal(txt_Luong.Text);
            string maSoThue = txt_MaSoThue.Text;
            string tenDangNhap = txt_TenDangNhap.Text;
            string matKhau = txt_MatKhau.Text;
            string vaiTro = txt_VaiTro.Text;

            // Gọi stored procedure AddEmployee với các tham số tương ứng
            AddEmployee(maSo, ten, ngaySinh, email, phongBan, luong, maSoThue, tenDangNhap, matKhau, vaiTro);

            // Tải lại dữ liệu sau khi thêm
            LoadData();
        }

        // Phương thức để gọi stored procedure AddEmployee
        private void AddEmployee(int maSo, string ten, DateTime ngaySinh, string email, string phongBan, decimal luong, string maSoThue, string tenDangNhap, string matKhau, string vaiTro)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("AddEmployee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaSo", maSo);
                        command.Parameters.AddWithValue("@Ten", ten);
                        command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@PhongBan", phongBan);
                        command.Parameters.AddWithValue("@Luong", luong);
                        command.Parameters.AddWithValue("@MaSoThue", maSoThue);
                        command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);
                        command.Parameters.AddWithValue("@VaiTro", vaiTro);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        // Xử lý sự kiện Click của nút "Cập nhật"
        private void Update_button_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox trên form
            int maSo = Convert.ToInt32(txt_MaSo.Text);
            string ten = txt_Ten.Text;
            DateTime ngaySinh = Convert.ToDateTime(txt_NgaySinh.Text);
            string email = txt_Email.Text;
            string phongBan = txt_PhongBan.Text;
            decimal luong = Convert.ToDecimal(txt_Luong.Text);
            string maSoThue = txt_MaSoThue.Text;
            string tenDangNhap = txt_TenDangNhap.Text;
            string matKhau = txt_MatKhau.Text;
            string vaiTro = txt_VaiTro.Text;

            // Gọi stored procedure UpdateEmployee với các tham số tương ứng
            UpdateEmployee(maSo, ten, ngaySinh, email, phongBan, luong, maSoThue, tenDangNhap, matKhau, vaiTro);

            // Tải lại dữ liệu sau khi cập nhật
            LoadData();
        }

        // Phương thức để gọi stored procedure UpdateEmployee
        private void UpdateEmployee(int maSo, string ten, DateTime ngaySinh, string email, string phongBan, decimal luong, string maSoThue, string tenDangNhap, string matKhau, string vaiTro)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UpdateEmployee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaSo", maSo);
                        command.Parameters.AddWithValue("@Ten", ten);
                        command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@PhongBan", phongBan);
                        command.Parameters.AddWithValue("@Luong", luong);
                        command.Parameters.AddWithValue("@MaSoThue", maSoThue);
                        command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);
                        command.Parameters.AddWithValue("@VaiTro", vaiTro);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhân viên: " + ex.Message);
            }
        }

        // Xử lý sự kiện Click của nút "Xóa"
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int maSo = Convert.ToInt32(row.Cells["MaSo"].Value);

                    // Thực hiện lệnh SQL DELETE để xóa dữ liệu từ cơ sở dữ liệu
                    string deleteQuery = "DELETE FROM NhanVien WHERE MaSo = @MaSo";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MaSo", maSo);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    // Xóa dòng từ DataGridView
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void nhatky_Click(object sender, EventArgs e)
        {
            AuditLogViewer nhatKy = new AuditLogViewer();
            nhatKy.Show();

        }

        private void btnBackHumanResourseAdmin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            var result = MessageBox.Show("Do you want to Back?", "Cofirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
