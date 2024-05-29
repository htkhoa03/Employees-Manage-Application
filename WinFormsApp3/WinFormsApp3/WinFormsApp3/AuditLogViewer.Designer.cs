namespace WinFormsApp3
{
    partial class AuditLogViewer
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
            label1 = new Label();
            btnBackAuditLog = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(925, 345);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(472, 30);
            label1.Name = "label1";
            label1.Size = new Size(89, 29);
            label1.TabIndex = 1;
            label1.Text = "DIARY";
            // 
            // btnBackAuditLog
            // 
            btnBackAuditLog.BackColor = Color.DarkOrange;
            btnBackAuditLog.Location = new Point(472, 484);
            btnBackAuditLog.Name = "btnBackAuditLog";
            btnBackAuditLog.Size = new Size(120, 50);
            btnBackAuditLog.TabIndex = 2;
            btnBackAuditLog.Text = "Back";
            btnBackAuditLog.UseVisualStyleBackColor = false;
            btnBackAuditLog.Click += btnBackAuditLog_Click;
            // 
            // AuditLogViewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1166, 557);
            Controls.Add(btnBackAuditLog);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "AuditLogViewer";
            Text = "Audit Log Viewer";
            Load += NhatKy_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnBackAuditLog;
    }
}