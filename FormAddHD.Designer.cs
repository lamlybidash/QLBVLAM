namespace QLBV
{
    partial class FormAddHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddHD));
            btQuit = new Button();
            btFinal = new Button();
            nudSLT = new NumericUpDown();
            btAddThuoc = new Button();
            label11 = new Label();
            label10 = new Label();
            comboBoxThuoc = new ComboBox();
            dgvTienThuoc = new DataGridView();
            tbTienDichVu = new TextBox();
            tbTienKham = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            lbIdBN = new Label();
            lbSex = new Label();
            lbCountry = new Label();
            lbName = new Label();
            lbDate = new Label();
            label13 = new Label();
            lbIdHD = new Label();
            label14 = new Label();
            lbNgayTaoHD = new Label();
            label15 = new Label();
            checkBoxBaoHiem = new CheckBox();
            label16 = new Label();
            btDelThuoc = new Button();
            lbTongTien = new Label();
            btTinhTien = new Button();
            label17 = new Label();
            lbDonGia = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSLT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTienThuoc).BeginInit();
            SuspendLayout();
            // 
            // btQuit
            // 
            btQuit.BackColor = Color.FromArgb(128, 255, 255);
            btQuit.Location = new Point(799, 774);
            btQuit.Name = "btQuit";
            btQuit.Size = new Size(116, 47);
            btQuit.TabIndex = 9;
            btQuit.Text = "Hủy";
            btQuit.UseVisualStyleBackColor = false;
            btQuit.Click += btQuit_Click;
            // 
            // btFinal
            // 
            btFinal.BackColor = Color.FromArgb(128, 255, 255);
            btFinal.Location = new Point(799, 716);
            btFinal.Name = "btFinal";
            btFinal.Size = new Size(116, 47);
            btFinal.TabIndex = 8;
            btFinal.Text = "Hoàn thành";
            btFinal.UseVisualStyleBackColor = false;
            btFinal.Click += btFinal_Click;
            // 
            // nudSLT
            // 
            nudSLT.Location = new Point(768, 566);
            nudSLT.Name = "nudSLT";
            nudSLT.Size = new Size(65, 23);
            nudSLT.TabIndex = 32;
            // 
            // btAddThuoc
            // 
            btAddThuoc.BackColor = Color.FromArgb(128, 255, 255);
            btAddThuoc.Location = new Point(697, 610);
            btAddThuoc.Name = "btAddThuoc";
            btAddThuoc.Size = new Size(149, 40);
            btAddThuoc.TabIndex = 31;
            btAddThuoc.Text = "Thêm vào đơn thuốc";
            btAddThuoc.UseVisualStyleBackColor = false;
            btAddThuoc.Click += btAddThuoc_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(697, 566);
            label11.Name = "label11";
            label11.Size = new Size(61, 17);
            label11.TabIndex = 30;
            label11.Text = "Số lượng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(697, 494);
            label10.Name = "label10";
            label10.Size = new Size(68, 17);
            label10.TabIndex = 29;
            label10.Text = "Loại thuốc";
            // 
            // comboBoxThuoc
            // 
            comboBoxThuoc.FormattingEnabled = true;
            comboBoxThuoc.Location = new Point(768, 493);
            comboBoxThuoc.Name = "comboBoxThuoc";
            comboBoxThuoc.Size = new Size(114, 23);
            comboBoxThuoc.TabIndex = 28;
            comboBoxThuoc.SelectedIndexChanged += comboBoxThuoc_SelectedIndexChanged;
            // 
            // dgvTienThuoc
            // 
            dgvTienThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTienThuoc.Location = new Point(226, 494);
            dgvTienThuoc.Name = "dgvTienThuoc";
            dgvTienThuoc.RowHeadersWidth = 51;
            dgvTienThuoc.RowTemplate.Height = 25;
            dgvTienThuoc.Size = new Size(442, 256);
            dgvTienThuoc.TabIndex = 27;
            dgvTienThuoc.CellClick += dgvTienThuoc_CellClick;
            // 
            // tbTienDichVu
            // 
            tbTienDichVu.Location = new Point(226, 434);
            tbTienDichVu.Name = "tbTienDichVu";
            tbTienDichVu.Size = new Size(442, 23);
            tbTienDichVu.TabIndex = 24;
            // 
            // tbTienKham
            // 
            tbTienKham.Location = new Point(226, 374);
            tbTienKham.Name = "tbTienKham";
            tbTienKham.Size = new Size(442, 23);
            tbTienKham.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(74, 494);
            label8.Name = "label8";
            label8.Size = new Size(105, 25);
            label8.TabIndex = 17;
            label8.Text = "Tiền thuốc:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(74, 429);
            label7.Name = "label7";
            label7.Size = new Size(118, 25);
            label7.TabIndex = 16;
            label7.Text = "Tiền dịch vụ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(74, 369);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 15;
            label6.Text = "Tiền Khám:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(516, 203);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 14;
            label5.Text = "Quê quán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(516, 152);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 13;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 203);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 12;
            label3.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(516, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 19;
            label2.Text = "Họ tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(226, 9);
            label1.Name = "label1";
            label1.Size = new Size(509, 47);
            label1.TabIndex = 11;
            label1.Text = "NHẬP THÔNG TIN HÓA ĐƠN";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(74, 152);
            label12.Name = "label12";
            label12.Size = new Size(73, 25);
            label12.TabIndex = 19;
            label12.Text = "Mã BN:";
            // 
            // lbIdBN
            // 
            lbIdBN.AutoSize = true;
            lbIdBN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbIdBN.Location = new Point(226, 152);
            lbIdBN.Name = "lbIdBN";
            lbIdBN.Size = new Size(69, 25);
            lbIdBN.TabIndex = 19;
            lbIdBN.Text = "lbIdBN";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSex.Location = new Point(226, 203);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(57, 25);
            lbSex.TabIndex = 19;
            lbSex.Text = "lbSex";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbCountry.Location = new Point(631, 203);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(95, 25);
            lbCountry.TabIndex = 19;
            lbCountry.Text = "lbCountry";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(631, 101);
            lbName.Name = "lbName";
            lbName.Size = new Size(78, 25);
            lbName.TabIndex = 19;
            lbName.Text = "lbName";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(631, 152);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(67, 25);
            lbDate.TabIndex = 19;
            lbDate.Text = "lbDate";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(74, 101);
            label13.Name = "label13";
            label13.Size = new Size(74, 25);
            label13.TabIndex = 19;
            label13.Text = "Mã HĐ:";
            // 
            // lbIdHD
            // 
            lbIdHD.AutoSize = true;
            lbIdHD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbIdHD.Location = new Point(226, 101);
            lbIdHD.Name = "lbIdHD";
            lbIdHD.Size = new Size(70, 25);
            lbIdHD.TabIndex = 19;
            lbIdHD.Text = "lbIdHD";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(74, 260);
            label14.Name = "label14";
            label14.Size = new Size(122, 25);
            label14.TabIndex = 12;
            label14.Text = "Ngày lập HĐ:";
            // 
            // lbNgayTaoHD
            // 
            lbNgayTaoHD.AutoSize = true;
            lbNgayTaoHD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbNgayTaoHD.Location = new Point(226, 260);
            lbNgayTaoHD.Name = "lbNgayTaoHD";
            lbNgayTaoHD.Size = new Size(170, 25);
            lbNgayTaoHD.TabIndex = 19;
            lbNgayTaoHD.Text = "lbNgayTaoHoaDon";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(74, 312);
            label15.Name = "label15";
            label15.Size = new Size(130, 25);
            label15.TabIndex = 12;
            label15.Text = "Bảo hiểm y tế:";
            // 
            // checkBoxBaoHiem
            // 
            checkBoxBaoHiem.AutoSize = true;
            checkBoxBaoHiem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxBaoHiem.Location = new Point(226, 308);
            checkBoxBaoHiem.Name = "checkBoxBaoHiem";
            checkBoxBaoHiem.Size = new Size(138, 29);
            checkBoxBaoHiem.TabIndex = 33;
            checkBoxBaoHiem.Text = "Có bảo hiểm";
            checkBoxBaoHiem.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(361, 308);
            label16.Name = "label16";
            label16.Size = new Size(68, 25);
            label16.TabIndex = 19;
            label16.Text = "(-35%)";
            // 
            // btDelThuoc
            // 
            btDelThuoc.BackColor = Color.FromArgb(128, 255, 255);
            btDelThuoc.Location = new Point(697, 656);
            btDelThuoc.Name = "btDelThuoc";
            btDelThuoc.Size = new Size(149, 40);
            btDelThuoc.TabIndex = 31;
            btDelThuoc.Text = "Loại khỏi đơn thuốc";
            btDelThuoc.UseVisualStyleBackColor = false;
            btDelThuoc.Click += btDelThuoc_Click;
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTongTien.Location = new Point(226, 767);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(66, 25);
            lbTongTien.TabIndex = 19;
            lbTongTien.Text = "0 VNĐ";
            // 
            // btTinhTien
            // 
            btTinhTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btTinhTien.ForeColor = Color.Red;
            btTinhTien.Location = new Point(74, 764);
            btTinhTien.Name = "btTinhTien";
            btTinhTien.Size = new Size(105, 36);
            btTinhTien.TabIndex = 34;
            btTinhTien.Text = "Thành Tiền";
            btTinhTien.UseVisualStyleBackColor = true;
            btTinhTien.Click += btTinhTien_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(697, 532);
            label17.Name = "label17";
            label17.Size = new Size(55, 17);
            label17.TabIndex = 29;
            label17.Text = "Đơn Giá";
            // 
            // lbDonGia
            // 
            lbDonGia.AutoSize = true;
            lbDonGia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbDonGia.Location = new Point(768, 532);
            lbDonGia.Name = "lbDonGia";
            lbDonGia.Size = new Size(0, 17);
            lbDonGia.TabIndex = 29;
            // 
            // FormAddHD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(924, 832);
            Controls.Add(btTinhTien);
            Controls.Add(checkBoxBaoHiem);
            Controls.Add(nudSLT);
            Controls.Add(btDelThuoc);
            Controls.Add(btAddThuoc);
            Controls.Add(label11);
            Controls.Add(lbDonGia);
            Controls.Add(label17);
            Controls.Add(label10);
            Controls.Add(comboBoxThuoc);
            Controls.Add(dgvTienThuoc);
            Controls.Add(tbTienDichVu);
            Controls.Add(tbTienKham);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label3);
            Controls.Add(lbCountry);
            Controls.Add(label16);
            Controls.Add(lbTongTien);
            Controls.Add(lbNgayTaoHD);
            Controls.Add(lbSex);
            Controls.Add(lbDate);
            Controls.Add(lbName);
            Controls.Add(lbIdHD);
            Controls.Add(lbIdBN);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btQuit);
            Controls.Add(btFinal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAddHD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý hóa đơn";
            FormClosing += FormQLHD_FormClosing;
            Load += FormQLHD_Load;
            ((System.ComponentModel.ISupportInitialize)nudSLT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTienThuoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btQuit;
        private Button btFinal;
        private NumericUpDown nudSLT;
        private Button btAddThuoc;
        private Label label11;
        private Label label10;
        private ComboBox comboBoxThuoc;
        private DataGridView dgvTienThuoc;
        private TextBox tbTienDichVu;
        private TextBox tbTienKham;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label12;
        private Label lbIdBN;
        private Label lbSex;
        private Label lbCountry;
        private Label lbName;
        private Label lbDate;
        private Label label13;
        private Label lbIdHD;
        private Label label14;
        private Label lbNgayTaoHD;
        private Label label15;
        private CheckBox checkBoxBaoHiem;
        private Label label16;
        private Button btDelThuoc;
        private Label lbTongTien;
        private Button btTinhTien;
        private Label label17;
        private Label lbDonGia;
    }
}