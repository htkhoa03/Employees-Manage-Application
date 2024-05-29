using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WinFormsApp3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-BQ49Q1R;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Encrypt=False";
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra tên đăng nhập và mật khẩu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Thực thi stored procedure để kiểm tra đăng nhập và lấy vai trò của người dùng
                    SqlCommand command = new SqlCommand("LoginAndGetRole", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    command.Parameters.AddWithValue("@TenDangNhap", username);
                    command.Parameters.AddWithValue("@MatKhau", password);

                    SqlParameter roleParam = new SqlParameter("@VaiTro", SqlDbType.NVarChar, 50);
                    roleParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(roleParam);

                    command.ExecuteNonQuery();

                    // Lấy vai trò từ output parameter
                    string role = command.Parameters["@VaiTro"].Value.ToString();

                    if (!string.IsNullOrEmpty(role) && username != null)
                    {
                        MessageBox.Show("Đăng nhập thành công với vai trò: " + role);
                        switch (role)
                        {
                            case "User":
                                UserForm userForm = new UserForm(username);
                                userForm.Show();
                                this.Hide();
                                break;
                            case "Admin":
                                AdminForm adminForm = new AdminForm(username);
                                adminForm.Show();
                                this.Hide();
                                break;
                            case "HumanResource_User":
                                HumanResourceUserForm hrUserForm = new HumanResourceUserForm(username);
                                hrUserForm.Show();
                                this.Hide();
                                break;
                            case "HumanResource_Admin":
                                HumanResourceAdminForm hrAdminForm = new HumanResourceAdminForm(username);
                                hrAdminForm.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Không tìm thấy vai trò cho người dùng.");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "Cofirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.KeyPress += new KeyPressEventHandler(txtFields_KeyPress);
            txtPassword.KeyPress += new KeyPressEventHandler(txtFields_KeyPress);
        }
        private void txtFields_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true; 
            }
        }
    }
}