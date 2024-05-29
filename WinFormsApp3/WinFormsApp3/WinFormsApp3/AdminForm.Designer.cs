namespace WinFormsApp3
{
    partial class AdminForm
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
            lblAdminForm = new Label();
            btnBackAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(681, 362);
            dataGridView1.TabIndex = 0;
            // 
            // lblAdminForm
            // 
            lblAdminForm.AutoSize = true;
            lblAdminForm.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAdminForm.Location = new Point(339, 31);
            lblAdminForm.Name = "lblAdminForm";
            lblAdminForm.Size = new Size(90, 29);
            lblAdminForm.TabIndex = 1;
            lblAdminForm.Text = "Admin";
            // 
            // btnBackAdmin
            // 
            btnBackAdmin.BackColor = Color.DarkOrange;
            btnBackAdmin.Location = new Point(330, 464);
            btnBackAdmin.Name = "btnBackAdmin";
            btnBackAdmin.Size = new Size(120, 50);
            btnBackAdmin.TabIndex = 2;
            btnBackAdmin.Text = "Back";
            btnBackAdmin.UseVisualStyleBackColor = false;
            btnBackAdmin.Click += btnBackAdmin_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(783, 526);
            Controls.Add(btnBackAdmin);
            Controls.Add(lblAdminForm);
            Controls.Add(dataGridView1);
            Name = "AdminForm";
            Text = "Admin Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblAdminForm;
        private Button btnBackAdmin;
    }
}