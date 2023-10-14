namespace QLBV
{
    partial class FormQuanLyBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyBenhNhan));
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cbbSearch = new ComboBox();
            txbSearch = new TextBox();
            btnSearch = new Button();
            dtgvBN = new DataGridView();
            label1 = new Label();
            btnBenhAn = new Button();
            btnHoaDon = new Button();
            label2 = new Label();
            Reloadform = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvBN).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1183, 681);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 32);
            btnExit.TabIndex = 18;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1025, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 57);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1025, 316);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 55);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1025, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 55);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbbSearch
            // 
            cbbSearch.FormattingEnabled = true;
            cbbSearch.Items.AddRange(new object[] { "maBN", "hoTen", "gioiTinh", "ngaySinh", "cccd", "ngheNghiep", "sdt", "bhyt", "diaChi" });
            cbbSearch.Location = new Point(910, 99);
            cbbSearch.Name = "cbbSearch";
            cbbSearch.Size = new Size(151, 28);
            cbbSearch.TabIndex = 14;
            cbbSearch.Text = "Chọn giá trị tìm kiếm";
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(910, 169);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(151, 27);
            txbSearch.TabIndex = 13;
            txbSearch.Text = "Nhập vào giá trị tìm kiếm tương ứng";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1090, 99);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 101);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtgvBN
            // 
            dtgvBN.BackgroundColor = Color.FromArgb(192, 255, 255);
            dtgvBN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBN.Location = new Point(34, 99);
            dtgvBN.Name = "dtgvBN";
            dtgvBN.RowHeadersWidth = 51;
            dtgvBN.RowTemplate.Height = 29;
            dtgvBN.Size = new Size(831, 615);
            dtgvBN.TabIndex = 11;
            dtgvBN.CellClick += dtgvBN_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, -101);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 10;
            label1.Text = "Nhân viên";
            // 
            // btnBenhAn
            // 
            btnBenhAn.Location = new Point(1025, 439);
            btnBenhAn.Name = "btnBenhAn";
            btnBenhAn.Size = new Size(94, 63);
            btnBenhAn.TabIndex = 19;
            btnBenhAn.Text = "Bệnh án";
            btnBenhAn.UseVisualStyleBackColor = true;
            btnBenhAn.Click += btnBenhAn_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Location = new Point(1025, 507);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(94, 69);
            btnHoaDon.TabIndex = 20;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(570, 12);
            label2.Name = "label2";
            label2.Size = new Size(356, 55);
            label2.TabIndex = 21;
            label2.Text = "Quản lý bệnh nhân";
            label2.Click += label2_Click;
            // 
            // Reloadform
            // 
            Reloadform.Location = new Point(34, 56);
            Reloadform.Name = "Reloadform";
            Reloadform.Size = new Size(135, 37);
            Reloadform.TabIndex = 22;
            Reloadform.Text = "Reload";
            Reloadform.UseVisualStyleBackColor = true;
            Reloadform.Click += Reloadform_Click;
            // 
            // FormQuanLyBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._0834_jpg_wh1200;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1297, 735);
            Controls.Add(Reloadform);
            Controls.Add(label2);
            Controls.Add(btnHoaDon);
            Controls.Add(btnBenhAn);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbbSearch);
            Controls.Add(txbSearch);
            Controls.Add(btnSearch);
            Controls.Add(dtgvBN);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormQuanLyBenhNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bênh nhân";
            Load += FormQuanLyBenhNhan_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvBN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cbbSearch;
        private TextBox txbSearch;
        private Button btnSearch;
        private DataGridView dtgvBN;
        private Label label1;
        private Button btnBenhAn;
        private Button btnHoaDon;
        private Label label2;
        private Button Reloadform;
    }
}