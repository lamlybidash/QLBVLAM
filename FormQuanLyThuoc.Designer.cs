namespace QLBV
{
    partial class FormQuanLyThuoc
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
            label1 = new Label();
            dtgvThuoc = new DataGridView();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txbSearch = new TextBox();
            cbbSearch = new ComboBox();
            btnAdd = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvThuoc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(304, 30);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 0;
            label1.Text = "Thuốc";
            // 
            // dtgvThuoc
            // 
            dtgvThuoc.BackgroundColor = Color.White;
            dtgvThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvThuoc.Location = new Point(12, 108);
            dtgvThuoc.Margin = new Padding(3, 2, 3, 2);
            dtgvThuoc.Name = "dtgvThuoc";
            dtgvThuoc.RowHeadersWidth = 51;
            dtgvThuoc.RowTemplate.Height = 29;
            dtgvThuoc.Size = new Size(480, 375);
            dtgvThuoc.TabIndex = 1;
            dtgvThuoc.CellClick += dtgvThuoc_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 255);
            btnSearch.Location = new Point(639, 115);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(66, 47);
            btnSearch.TabIndex = 32;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 255, 255);
            btnDelete.Location = new Point(578, 379);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 37);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Xoá";
            btnDelete.TextImageRelation = TextImageRelation.TextAboveImage;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnUpdate.Location = new Point(578, 302);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 37);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.TextImageRelation = TextImageRelation.TextAboveImage;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(514, 139);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(101, 23);
            txbSearch.TabIndex = 27;
            // 
            // cbbSearch
            // 
            cbbSearch.BackColor = Color.WhiteSmoke;
            cbbSearch.FormattingEnabled = true;
            cbbSearch.Items.AddRange(new object[] { "maThuoc", "tenThuoc", "donGia", "soLuong" });
            cbbSearch.Location = new Point(514, 110);
            cbbSearch.Name = "cbbSearch";
            cbbSearch.Size = new Size(101, 23);
            cbbSearch.TabIndex = 26;
            cbbSearch.Text = "Select search value";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 255);
            btnAdd.Location = new Point(578, 226);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 37);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 255, 255);
            btnExit.Location = new Point(580, 494);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 34);
            btnExit.TabIndex = 24;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormQuanLyThuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.thuoc_20191031095705PM1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 544);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txbSearch);
            Controls.Add(cbbSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnExit);
            Controls.Add(dtgvThuoc);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormQuanLyThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thuốc";
            Load += FormQuanLyThuoc_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvThuoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgvThuoc;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txbSearch;
        private ComboBox cbbSearch;
        private Button btnAdd;
        private Button btnExit;
    }
}