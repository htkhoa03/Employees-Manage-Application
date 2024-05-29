using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class AdminForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-BQ49Q1R;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Encrypt=False";
        private string username;

        public AdminForm(string username)
        {
            InitializeComponent();
            this.username = username;
            this.FormClosing += AdminForm_FormClosing;
            this.Load += AdminForm_Load;
        }

        private void AdminForm_Load(object sender, EventArgs e)
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

                    // Gọi stored procedure để lấy thông tin nhân viên trong phòng ban của người dùng
                    using (SqlCommand command = new SqlCommand("GetEmployeesInUserDepartment", connection))
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

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu đóng cửa sổ là do người dùng nhấn nút đóng
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Đóng tất cả các cửa sổ và thoát chương trình
                Application.Exit();
            }
        }

        private void btnBackAdmin_Click(object sender, EventArgs e)
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
