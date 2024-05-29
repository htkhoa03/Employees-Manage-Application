using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class AcountantForm : Form
    {
        public AcountantForm()
        {
            InitializeComponent();
        }

        private void btnBackAccountant_Click(object sender, EventArgs e)
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
