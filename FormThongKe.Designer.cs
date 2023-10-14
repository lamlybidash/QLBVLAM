namespace QLBV
{
    partial class FormThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            label1 = new Label();
            dtgvThongKe = new DataGridView();
            dtpkFrom = new DateTimePicker();
            dtpkTo = new DateTimePicker();
            btnThongKe = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(646, 24);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Thống kê hóa đơn";
            // 
            // dtgvThongKe
            // 
            dtgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvThongKe.Location = new Point(12, 133);
            dtgvThongKe.Name = "dtgvThongKe";
            dtgvThongKe.RowHeadersWidth = 51;
            dtgvThongKe.RowTemplate.Height = 29;
            dtgvThongKe.Size = new Size(1550, 749);
            dtgvThongKe.TabIndex = 1;
            // 
            // dtpkFrom
            // 
            dtpkFrom.Location = new Point(382, 74);
            dtpkFrom.Name = "dtpkFrom";
            dtpkFrom.Size = new Size(154, 27);
            dtpkFrom.TabIndex = 2;
            // 
            // dtpkTo
            // 
            dtpkTo.Location = new Point(1087, 86);
            dtpkTo.Name = "dtpkTo";
            dtpkTo.Size = new Size(154, 27);
            dtpkTo.TabIndex = 3;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(622, 72);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(94, 29);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(774, 72);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 29);
            btnExport.TabIndex = 5;
            btnExport.Text = "Xuất Excel";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 885);
            Controls.Add(btnExport);
            Controls.Add(btnThongKe);
            Controls.Add(dtpkTo);
            Controls.Add(dtpkFrom);
            Controls.Add(dtgvThongKe);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)dtgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgvThongKe;
        private DateTimePicker dtpkFrom;
        private DateTimePicker dtpkTo;
        private Button btnThongKe;
        private Button btnExport;
    }
}