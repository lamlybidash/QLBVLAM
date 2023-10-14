namespace QLBV
{
    partial class FormCapNhatNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapNhatNhanVien));
            cbbGT = new ComboBox();
            label8 = new Label();
            dtpkNgaySinh = new DateTimePicker();
            txbDiaChi = new TextBox();
            label7 = new Label();
            txbQueQuan = new TextBox();
            label6 = new Label();
            txbSDT = new TextBox();
            label5 = new Label();
            txbChucVu = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txbHoTen = new TextBox();
            label2 = new Label();
            txbMaNV = new TextBox();
            label1 = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // cbbGT
            // 
            cbbGT.FormattingEnabled = true;
            cbbGT.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGT.Location = new Point(235, 217);
            cbbGT.Name = "cbbGT";
            cbbGT.Size = new Size(151, 28);
            cbbGT.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(138, 221);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 36;
            label8.Text = "Giới tính";
            // 
            // dtpkNgaySinh
            // 
            dtpkNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpkNgaySinh.Location = new Point(235, 260);
            dtpkNgaySinh.Name = "dtpkNgaySinh";
            dtpkNgaySinh.Size = new Size(142, 27);
            dtpkNgaySinh.TabIndex = 44;
            // 
            // txbDiaChi
            // 
            txbDiaChi.Location = new Point(539, 239);
            txbDiaChi.Name = "txbDiaChi";
            txbDiaChi.Size = new Size(125, 27);
            txbDiaChi.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(443, 245);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 42;
            label7.Text = "Địa chỉ";
            // 
            // txbQueQuan
            // 
            txbQueQuan.Location = new Point(539, 169);
            txbQueQuan.Name = "txbQueQuan";
            txbQueQuan.Size = new Size(125, 27);
            txbQueQuan.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(443, 176);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 40;
            label6.Text = "Quê quán";
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(547, 109);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(125, 27);
            txbSDT.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 109);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 37;
            label5.Text = "Số điện thoại";
            // 
            // txbChucVu
            // 
            txbChucVu.Location = new Point(235, 316);
            txbChucVu.Name = "txbChucVu";
            txbChucVu.Size = new Size(125, 27);
            txbChucVu.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 323);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 34;
            label4.Text = "Chức vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 260);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 33;
            label3.Text = "Ngày sinh";
            // 
            // txbHoTen
            // 
            txbHoTen.Location = new Point(235, 173);
            txbHoTen.Name = "txbHoTen";
            txbHoTen.Size = new Size(125, 27);
            txbHoTen.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 180);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 31;
            label2.Text = "Họ tên";
            // 
            // txbMaNV
            // 
            txbMaNV.Location = new Point(235, 107);
            txbMaNV.Name = "txbMaNV";
            txbMaNV.ReadOnly = true;
            txbMaNV.Size = new Size(125, 27);
            txbMaNV.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 115);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 29;
            label1.Text = "Mã NV";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnUpdate.Location = new Point(335, 391);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(128, 255, 255);
            btnClear.Location = new Point(463, 391);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 46;
            btnClear.Text = "Xóa";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 255, 255);
            btnExit.Location = new Point(578, 391);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 47;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(335, 41);
            label9.Name = "label9";
            label9.Size = new Size(199, 20);
            label9.TabIndex = 48;
            label9.Text = "Cập nhật thông tin nhân viên";
            // 
            // FormCapNhatNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 451);
            Controls.Add(label9);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(cbbGT);
            Controls.Add(label8);
            Controls.Add(dtpkNgaySinh);
            Controls.Add(txbDiaChi);
            Controls.Add(label7);
            Controls.Add(txbQueQuan);
            Controls.Add(label6);
            Controls.Add(txbSDT);
            Controls.Add(label5);
            Controls.Add(txbChucVu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txbHoTen);
            Controls.Add(label2);
            Controls.Add(txbMaNV);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCapNhatNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật thông tin nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbGT;
        private Label label8;
        private DateTimePicker dtpkNgaySinh;
        private TextBox txbDiaChi;
        private Label label7;
        private TextBox txbQueQuan;
        private Label label6;
        private TextBox txbSDT;
        private Label label5;
        private TextBox txbChucVu;
        private Label label4;
        private Label label3;
        private TextBox txbHoTen;
        private Label label2;
        private TextBox txbMaNV;
        private Label label1;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnExit;
        private Label label9;
    }
}