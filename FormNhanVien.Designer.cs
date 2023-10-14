namespace QLBV
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            label1 = new Label();
            dtgvNV = new DataGridView();
            btnSearch = new Button();
            txbSearch = new TextBox();
            cbbSearch = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            btnExportExcel = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dtgvNV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(523, 12);
            label1.Name = "label1";
            label1.Size = new Size(170, 46);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên";
            // 
            // dtgvNV
            // 
            dtgvNV.BackgroundColor = Color.FromArgb(192, 255, 255);
            dtgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvNV.Location = new Point(587, 247);
            dtgvNV.Name = "dtgvNV";
            dtgvNV.RowHeadersWidth = 51;
            dtgvNV.RowTemplate.Height = 29;
            dtgvNV.Size = new Size(640, 429);
            dtgvNV.TabIndex = 1;
            dtgvNV.CellClick += dtgvNV_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 255);
            btnSearch.Location = new Point(1059, 135);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 77);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(845, 181);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(151, 27);
            txbSearch.TabIndex = 3;
            // 
            // cbbSearch
            // 
            cbbSearch.FormattingEnabled = true;
            cbbSearch.Items.AddRange(new object[] { "maNV", "hoTen", "gioiTinh", "chucVu", "sdt", "queQuan", "diaChi" });
            cbbSearch.Location = new Point(845, 131);
            cbbSearch.Name = "cbbSearch";
            cbbSearch.Size = new Size(151, 28);
            cbbSearch.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 255);
            btnAdd.Location = new Point(459, 361);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 77);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnUpdate.Location = new Point(459, 247);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 77);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 255, 255);
            btnDelete.Location = new Point(459, 481);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 77);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 255, 255);
            btnExit.Location = new Point(459, 599);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 77);
            btnExit.TabIndex = 9;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.FromArgb(128, 255, 255);
            btnExportExcel.Location = new Point(235, 36);
            btnExportExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(107, 39);
            btnExportExcel.TabIndex = 10;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.doctor;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1410, 943);
            Controls.Add(btnExportExcel);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbbSearch);
            Controls.Add(txbSearch);
            Controls.Add(btnSearch);
            Controls.Add(dtgvNV);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += FormNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgvNV;
        private Button btnSearch;
        private TextBox txbSearch;
        private ComboBox cbbSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Button btnExportExcel;
        private SaveFileDialog saveFileDialog1;
    }
}