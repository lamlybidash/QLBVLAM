namespace QLBV
{
    partial class FormQuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyHoaDon));
            btQuit = new Button();
            btDel = new Button();
            btAdd = new Button();
            label11 = new Label();
            dgvDSThuoc = new DataGridView();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbSex = new Label();
            lbIdHD = new Label();
            lbIdBN = new Label();
            lbCountry = new Label();
            lbDate = new Label();
            lbName = new Label();
            label12 = new Label();
            lbTienKham = new Label();
            lbTienDichVu = new Label();
            panel1 = new Panel();
            lbTongTien = new Label();
            lbTienBaoHiem = new Label();
            lbDateHD = new Label();
            label13 = new Label();
            label14 = new Label();
            cbbDSHD = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDSThuoc).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btQuit
            // 
            btQuit.BackColor = Color.FromArgb(128, 255, 255);
            btQuit.Location = new Point(935, 791);
            btQuit.Name = "btQuit";
            btQuit.Size = new Size(104, 37);
            btQuit.TabIndex = 11;
            btQuit.Text = "Trở về";
            btQuit.UseVisualStyleBackColor = false;
            btQuit.Click += btQuit_Click;
            // 
            // btDel
            // 
            btDel.BackColor = Color.FromArgb(128, 255, 255);
            btDel.Location = new Point(909, 298);
            btDel.Name = "btDel";
            btDel.Size = new Size(130, 54);
            btDel.TabIndex = 12;
            btDel.Text = "Xóa hóa đơn";
            btDel.UseVisualStyleBackColor = false;
            btDel.Click += btDel_Click;
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.FromArgb(128, 255, 255);
            btAdd.Location = new Point(907, 166);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(130, 54);
            btAdd.TabIndex = 13;
            btAdd.Text = "Thêm hóa đơn";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(14, 90);
            label11.Name = "label11";
            label11.Size = new Size(79, 25);
            label11.TabIndex = 32;
            label11.Text = "Mã HĐ:";
            // 
            // dgvDSThuoc
            // 
            dgvDSThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSThuoc.Location = new Point(179, 467);
            dgvDSThuoc.Name = "dgvDSThuoc";
            dgvDSThuoc.RowHeadersWidth = 51;
            dgvDSThuoc.RowTemplate.Height = 25;
            dgvDSThuoc.Size = new Size(431, 210);
            dgvDSThuoc.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(14, 758);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 21;
            label9.Text = "Thành tiền";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 467);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 20;
            label8.Text = "Tiền thuốc:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 389);
            label7.Name = "label7";
            label7.Size = new Size(124, 25);
            label7.TabIndex = 19;
            label7.Text = "Tiền dịch vụ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 312);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 18;
            label6.Text = "Tiền Khám:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(263, 193);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 17;
            label5.Text = "Quê quán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(263, 142);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 16;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 193);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 15;
            label3.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(263, 90);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 22;
            label2.Text = "Họ tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 16);
            label1.Name = "label1";
            label1.Size = new Size(397, 47);
            label1.TabIndex = 14;
            label1.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSex.Location = new Point(155, 194);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(0, 25);
            lbSex.TabIndex = 33;
            // 
            // lbIdHD
            // 
            lbIdHD.AutoSize = true;
            lbIdHD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbIdHD.Location = new Point(154, 90);
            lbIdHD.Name = "lbIdHD";
            lbIdHD.Size = new Size(0, 25);
            lbIdHD.TabIndex = 34;
            // 
            // lbIdBN
            // 
            lbIdBN.AutoSize = true;
            lbIdBN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbIdBN.Location = new Point(155, 142);
            lbIdBN.Name = "lbIdBN";
            lbIdBN.Size = new Size(0, 25);
            lbIdBN.TabIndex = 35;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbCountry.Location = new Point(383, 193);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(0, 25);
            lbCountry.TabIndex = 36;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(383, 142);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(0, 25);
            lbDate.TabIndex = 37;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(383, 90);
            lbName.Name = "lbName";
            lbName.Size = new Size(0, 25);
            lbName.TabIndex = 38;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(14, 142);
            label12.Name = "label12";
            label12.Size = new Size(77, 25);
            label12.TabIndex = 32;
            label12.Text = "Mã BN:";
            // 
            // lbTienKham
            // 
            lbTienKham.AutoSize = true;
            lbTienKham.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTienKham.Location = new Point(179, 312);
            lbTienKham.Name = "lbTienKham";
            lbTienKham.Size = new Size(0, 25);
            lbTienKham.TabIndex = 33;
            // 
            // lbTienDichVu
            // 
            lbTienDichVu.AutoSize = true;
            lbTienDichVu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTienDichVu.Location = new Point(179, 389);
            lbTienDichVu.Name = "lbTienDichVu";
            lbTienDichVu.Size = new Size(0, 25);
            lbTienDichVu.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbCountry);
            panel1.Controls.Add(lbDate);
            panel1.Controls.Add(lbName);
            panel1.Controls.Add(lbTongTien);
            panel1.Controls.Add(lbTienBaoHiem);
            panel1.Controls.Add(lbTienDichVu);
            panel1.Controls.Add(lbTienKham);
            panel1.Controls.Add(lbDateHD);
            panel1.Controls.Add(lbSex);
            panel1.Controls.Add(lbIdHD);
            panel1.Controls.Add(lbIdBN);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dgvDSThuoc);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(166, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 815);
            panel1.TabIndex = 39;
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTongTien.Location = new Point(179, 758);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(0, 25);
            lbTongTien.TabIndex = 33;
            // 
            // lbTienBaoHiem
            // 
            lbTienBaoHiem.AutoSize = true;
            lbTienBaoHiem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTienBaoHiem.Location = new Point(179, 705);
            lbTienBaoHiem.Name = "lbTienBaoHiem";
            lbTienBaoHiem.Size = new Size(0, 25);
            lbTienBaoHiem.TabIndex = 33;
            // 
            // lbDateHD
            // 
            lbDateHD.AutoSize = true;
            lbDateHD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbDateHD.Location = new Point(155, 251);
            lbDateHD.Name = "lbDateHD";
            lbDateHD.Size = new Size(0, 25);
            lbDateHD.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(14, 705);
            label13.Name = "label13";
            label13.Size = new Size(99, 25);
            label13.TabIndex = 15;
            label13.Text = "Bảo hiểm:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(14, 251);
            label14.Name = "label14";
            label14.Size = new Size(135, 25);
            label14.TabIndex = 15;
            label14.Text = "Ngày lập  HĐ:";
            // 
            // cbbDSHD
            // 
            cbbDSHD.FormattingEnabled = true;
            cbbDSHD.Location = new Point(907, 50);
            cbbDSHD.Margin = new Padding(3, 2, 3, 2);
            cbbDSHD.Name = "cbbDSHD";
            cbbDSHD.Size = new Size(133, 23);
            cbbDSHD.TabIndex = 40;
            cbbDSHD.Text = "Danh sách hóa đơn";
            cbbDSHD.SelectedIndexChanged += cbbDSHD_SelectedIndexChanged;
            // 
            // FormQuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__3_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 855);
            Controls.Add(cbbDSHD);
            Controls.Add(panel1);
            Controls.Add(btQuit);
            Controls.Add(btDel);
            Controls.Add(btAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormQuanLyHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += FormQuanLyHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSThuoc).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btQuit;
        private Button btDel;
        private Button btAdd;
        private Label label11;
        private DataGridView dgvDSThuoc;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbSex;
        private Label lbIdHD;
        private Label lbIdBN;
        private Label lbCountry;
        private Label lbDate;
        private Label lbName;
        private Label label12;
        private Label lbTienKham;
        private Label lbTienDichVu;
        private Panel panel1;
        private Label label13;
        private Label lbTongTien;
        private Label lbTienBaoHiem;
        private Label lbDateHD;
        private Label label14;
        private ComboBox cbbDSHD;
    }
}