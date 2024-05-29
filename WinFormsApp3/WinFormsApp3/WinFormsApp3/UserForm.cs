using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class UserForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BQ49Q1R;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Encrypt=False";
        private string username;

        public UserForm(string username)
        {
            InitializeComponent();
            this.username = username;
            this.FormClosing += UserForm_FormClosing;
            this.Load += UserForm_Load;
        }

        private void UserForm_Load(object sender, EventArgs e)
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

                    // Lấy thông tin về phòng ban của người dùng từ tên đăng nhập
                    string queryPhongBan = "SELECT PhongBan FROM NhanVien WHERE TenDangNhap = @TenDangNhap";
                    using (SqlCommand commandPhongBan = new SqlCommand(queryPhongBan, connection))
                    {
                        commandPhongBan.Parameters.AddWithValue("@TenDangNhap", username);
                        string department = commandPhongBan.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(department))
                        {
                            // Lấy thông tin của nhân viên trong phòng ban
                            string query = "SELECT Ten, NgaySinh, Email, PhongBan, MaSoThue, VaiTro FROM NhanVien WHERE PhongBan = @PhongBan";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@PhongBan", department);
                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);
                                    dataGridView1.DataSource = dataTable;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin phòng ban cho người dùng.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu đóng cửa sổ là do người dùng nhấn nút đóng
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Đóng tất cả các cửa sổ và thoát chương trình
                Application.Exit();
            }
        }

        private void btnBackUser_Click(object sender, EventArgs e)
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
