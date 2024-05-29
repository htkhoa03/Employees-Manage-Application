namespace WinFormsApp3
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            lbUserForm = new Label();
            btnBackUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(704, 312);
            dataGridView1.TabIndex = 0;
            // 
            // lbUserForm
            // 
            lbUserForm.AutoSize = true;
            lbUserForm.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserForm.Location = new Point(365, 37);
            lbUserForm.Name = "lbUserForm";
            lbUserForm.Size = new Size(74, 29);
            lbUserForm.TabIndex = 1;
            lbUserForm.Text = "User";
            // 
            // btnBackUser
            // 
            btnBackUser.BackColor = Color.DarkOrange;
            btnBackUser.Location = new Point(337, 439);
            btnBackUser.Name = "btnBackUser";
            btnBackUser.Size = new Size(120, 50);
            btnBackUser.TabIndex = 2;
            btnBackUser.Text = "Back";
            btnBackUser.UseVisualStyleBackColor = false;
            btnBackUser.Click += btnBackUser_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 501);
            Controls.Add(btnBackUser);
            Controls.Add(lbUserForm);
            Controls.Add(dataGridView1);
            Name = "UserForm";
            Text = "User ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbUserForm;
        private Button btnBackUser;
    }
}