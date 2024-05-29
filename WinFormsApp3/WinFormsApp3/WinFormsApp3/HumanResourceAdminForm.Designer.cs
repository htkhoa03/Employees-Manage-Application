namespace WinFormsApp3
{
    partial class HumanResourceAdminForm
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
            Add_button = new Button();
            Update_button = new Button();
            Delete_button = new Button();
            label1 = new Label();
            txt_MaSo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_NgaySinh = new TextBox();
            txt_Email = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_Ten = new TextBox();
            txt_PhongBan = new TextBox();
            txt_Luong = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_TenDangNhap = new TextBox();
            txt_MatKhau = new TextBox();
            txt_MaSoThue = new TextBox();
            label10 = new Label();
            txt_VaiTro = new TextBox();
            AudiLog = new Button();
            lblHumanResourseAdminForm = new Label();
            btnBackHumanResourseAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(838, 251);
            dataGridView1.TabIndex = 0;
            // 
            // Add_button
            // 
            Add_button.BackColor = Color.DarkOrange;
            Add_button.Location = new Point(39, 582);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(120, 50);
            Add_button.TabIndex = 1;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            Add_button.Click += Add_button_Click;
            // 
            // Update_button
            // 
            Update_button.BackColor = Color.DarkOrange;
            Update_button.Location = new Point(219, 582);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(120, 50);
            Update_button.TabIndex = 2;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = false;
            Update_button.Click += Update_button_Click;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = Color.DarkOrange;
            Delete_button.Location = new Point(402, 582);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(120, 50);
            Delete_button.TabIndex = 3;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = false;
            Delete_button.Click += Delete_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 389);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Number :";
            // 
            // txt_MaSo
            // 
            txt_MaSo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaSo.Location = new Point(117, 386);
            txt_MaSo.Name = "txt_MaSo";
            txt_MaSo.Size = new Size(196, 34);
            txt_MaSo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 441);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 6;
            label2.Text = "Birth Year :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 489);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Email :";
            // 
            // txt_NgaySinh
            // 
            txt_NgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_NgaySinh.Location = new Point(117, 438);
            txt_NgaySinh.Name = "txt_NgaySinh";
            txt_NgaySinh.Size = new Size(196, 34);
            txt_NgaySinh.TabIndex = 8;
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Email.Location = new Point(117, 486);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(196, 34);
            txt_Email.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 389);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 10;
            label4.Text = "Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 438);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 11;
            label5.Text = "Department :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 486);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 12;
            label6.Text = "Salary :";
            // 
            // txt_Ten
            // 
            txt_Ten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Ten.Location = new Point(431, 386);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(177, 34);
            txt_Ten.TabIndex = 13;
            // 
            // txt_PhongBan
            // 
            txt_PhongBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PhongBan.Location = new Point(431, 434);
            txt_PhongBan.Name = "txt_PhongBan";
            txt_PhongBan.Size = new Size(177, 34);
            txt_PhongBan.TabIndex = 14;
            // 
            // txt_Luong
            // 
            txt_Luong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Luong.Location = new Point(431, 479);
            txt_Luong.Name = "txt_Luong";
            txt_Luong.Size = new Size(177, 34);
            txt_Luong.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(628, 389);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 16;
            label7.Text = "User :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(628, 438);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 17;
            label8.Text = "Password :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(628, 489);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 18;
            label9.Text = "Tax Code :";
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TenDangNhap.Location = new Point(706, 386);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(171, 34);
            txt_TenDangNhap.TabIndex = 19;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MatKhau.Location = new Point(706, 434);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(171, 34);
            txt_MatKhau.TabIndex = 20;
            // 
            // txt_MaSoThue
            // 
            txt_MaSoThue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaSoThue.Location = new Point(706, 486);
            txt_MaSoThue.Name = "txt_MaSoThue";
            txt_MaSoThue.Size = new Size(171, 34);
            txt_MaSoThue.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(337, 533);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 22;
            label10.Text = "Role :";
            // 
            // txt_VaiTro
            // 
            txt_VaiTro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_VaiTro.Location = new Point(431, 523);
            txt_VaiTro.Name = "txt_VaiTro";
            txt_VaiTro.Size = new Size(177, 34);
            txt_VaiTro.TabIndex = 23;
            // 
            // AudiLog
            // 
            AudiLog.BackColor = Color.DarkOrange;
            AudiLog.Location = new Point(584, 582);
            AudiLog.Name = "AudiLog";
            AudiLog.Size = new Size(120, 50);
            AudiLog.TabIndex = 24;
            AudiLog.Text = "AudiLog";
            AudiLog.UseVisualStyleBackColor = false;
            AudiLog.Click += nhatky_Click;
            // 
            // lblHumanResourseAdminForm
            // 
            lblHumanResourseAdminForm.AutoSize = true;
            lblHumanResourseAdminForm.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHumanResourseAdminForm.Location = new Point(297, 40);
            lblHumanResourseAdminForm.Name = "lblHumanResourseAdminForm";
            lblHumanResourseAdminForm.Size = new Size(311, 29);
            lblHumanResourseAdminForm.TabIndex = 25;
            lblHumanResourseAdminForm.Text = "Human Resourse Admin";
            // 
            // btnBackHumanResourseAdmin
            // 
            btnBackHumanResourseAdmin.BackColor = Color.DarkOrange;
            btnBackHumanResourseAdmin.Location = new Point(768, 582);
            btnBackHumanResourseAdmin.Name = "btnBackHumanResourseAdmin";
            btnBackHumanResourseAdmin.Size = new Size(120, 50);
            btnBackHumanResourseAdmin.TabIndex = 26;
            btnBackHumanResourseAdmin.Text = "Back";
            btnBackHumanResourseAdmin.UseVisualStyleBackColor = false;
            btnBackHumanResourseAdmin.Click += btnBackHumanResourseAdmin_Click;
            // 
            // HumanResourceAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(918, 664);
            Controls.Add(btnBackHumanResourseAdmin);
            Controls.Add(lblHumanResourseAdminForm);
            Controls.Add(AudiLog);
            Controls.Add(txt_VaiTro);
            Controls.Add(label10);
            Controls.Add(txt_MaSoThue);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_TenDangNhap);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt_Luong);
            Controls.Add(txt_PhongBan);
            Controls.Add(txt_Ten);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_Email);
            Controls.Add(txt_NgaySinh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_MaSo);
            Controls.Add(label1);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(dataGridView1);
            Name = "HumanResourceAdminForm";
            Text = "Human Rersourse Admin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Add_button;
        private Button Update_button;
        private Button Delete_button;
        private Label label1;
        private TextBox txt_MaSo;
        private Label label2;
        private Label label3;
        private TextBox txt_NgaySinh;
        private TextBox txt_Email;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Ten;
        private TextBox txt_PhongBan;
        private TextBox txt_Luong;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_TenDangNhap;
        private TextBox txt_MatKhau;
        private TextBox txt_MaSoThue;
        private Label label10;
        private TextBox txt_VaiTro;
        private Button AudiLog;
        private Label lblHumanResourseAdminForm;
        private Button btnBackHumanResourseAdmin;
    }
}