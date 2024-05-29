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
    public partial class AuditLogViewer : Form
    {
        public AuditLogViewer()
        {
            InitializeComponent();
        }

        private void NhatKy_Load_1(object sender, EventArgs e)
        {
            LoadAuditLogData();
        }

        private void LoadAuditLogData()
        {
            // Define the connection string (replace with your actual connection string)
            string connectionString = @"Data Source=DESKTOP-BQ49Q1R;Initial Catalog=QuanLyNhanVien;Integrated Security=True;Encrypt=False";

            // Define the query to retrieve data from the AuditLog table
            string query = "SELECT LogID, ActionType, TableName, RecordID, RecordData, ModifiedBy, ModifiedDate FROM AuditLog";

            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Fill the DataTable with the data from the database
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void btnBackAuditLog_Click(object sender, EventArgs e)
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
