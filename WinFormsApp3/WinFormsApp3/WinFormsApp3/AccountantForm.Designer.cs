namespace WinFormsApp3
{
    partial class AcountantForm
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
            dgvAcountant = new DataGridView();
            lblAcountantForm = new Label();
            btnBackAccountant = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAcountant).BeginInit();
            SuspendLayout();
            // 
            // dgvAcountant
            // 
            dgvAcountant.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAcountant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcountant.Location = new Point(35, 89);
            dgvAcountant.Name = "dgvAcountant";
            dgvAcountant.RowHeadersWidth = 51;
            dgvAcountant.RowTemplate.Height = 29;
            dgvAcountant.Size = new Size(734, 305);
            dgvAcountant.TabIndex = 0;
            // 
            // lblAcountantForm
            // 
            lblAcountantForm.AutoSize = true;
            lblAcountantForm.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAcountantForm.Location = new Point(326, 34);
            lblAcountantForm.Name = "lblAcountantForm";
            lblAcountantForm.Size = new Size(153, 29);
            lblAcountantForm.TabIndex = 1;
            lblAcountantForm.Text = "ACOUNTANT";
            // 
            // btnBackAccountant
            // 
            btnBackAccountant.BackColor = Color.DarkOrange;
            btnBackAccountant.Location = new Point(337, 409);
            btnBackAccountant.Name = "btnBackAccountant";
            btnBackAccountant.Size = new Size(120, 50);
            btnBackAccountant.TabIndex = 2;
            btnBackAccountant.Text = "Back";
            btnBackAccountant.UseVisualStyleBackColor = false;
            btnBackAccountant.Click += btnBackAccountant_Click;
            // 
            // AcountantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 471);
            Controls.Add(btnBackAccountant);
            Controls.Add(lblAcountantForm);
            Controls.Add(dgvAcountant);
            Name = "AcountantForm";
            Text = "Accountant";
            ((System.ComponentModel.ISupportInitialize)dgvAcountant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAcountant;
        private Label lblAcountantForm;
        private Button btnBackAccountant;
    }
}