namespace QLBV
{
    partial class FormTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            menuStrip1 = new MenuStrip();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            btnQLBN = new Button();
            btnQLNV = new Button();
            button3 = new Button();
            btnQLThuoc = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            btnThongKe = new Button();
            btThoat = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thôngTinToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1359, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(85, 24);
            thôngTinToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(181, 26);
            thôngTinCáNhânToolStripMenuItem.Text = "Đổi mật khẩu";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(181, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // btnQLBN
            // 
            btnQLBN.BackColor = Color.FromArgb(128, 255, 255);
            btnQLBN.Location = new Point(421, 195);
            btnQLBN.Name = "btnQLBN";
            btnQLBN.Size = new Size(187, 67);
            btnQLBN.TabIndex = 2;
            btnQLBN.Text = "Quản lý Bệnh nhân";
            btnQLBN.UseVisualStyleBackColor = false;
            btnQLBN.Click += btnQLBN_Click;
            // 
            // btnQLNV
            // 
            btnQLNV.BackColor = Color.FromArgb(128, 255, 255);
            btnQLNV.Location = new Point(421, 357);
            btnQLNV.Name = "btnQLNV";
            btnQLNV.Size = new Size(187, 67);
            btnQLNV.TabIndex = 3;
            btnQLNV.Text = "Quản lý Nhân viên";
            btnQLNV.UseVisualStyleBackColor = false;
            btnQLNV.Click += btnQLNV_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Location = new Point(744, 195);
            button3.Name = "button3";
            button3.Size = new Size(187, 67);
            button3.TabIndex = 4;
            button3.Text = "Quản lý Giường bênh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnQLThuoc
            // 
            btnQLThuoc.BackColor = Color.FromArgb(128, 255, 255);
            btnQLThuoc.Location = new Point(744, 357);
            btnQLThuoc.Name = "btnQLThuoc";
            btnQLThuoc.Size = new Size(187, 67);
            btnQLThuoc.TabIndex = 5;
            btnQLThuoc.Text = "Quản lý Thuốc";
            btnQLThuoc.UseVisualStyleBackColor = false;
            btnQLThuoc.Click += btnQLThuoc_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(93, 620);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1198, 405);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới thiệu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(166, 39);
            label1.Name = "label1";
            label1.Size = new Size(863, 336);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(326, 88);
            label2.Name = "label2";
            label2.Size = new Size(779, 60);
            label2.TabIndex = 7;
            label2.Text = "PHẦN MỀM QUẢN LÝ BỆNH VIỆN ICTU";
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(128, 255, 255);
            btnThongKe.Location = new Point(421, 500);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(187, 67);
            btnThongKe.TabIndex = 8;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btThoat
            // 
            btThoat.BackColor = Color.FromArgb(128, 255, 255);
            btThoat.Location = new Point(744, 500);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(187, 67);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_579484323_waaeF98BnKROG1Ez3iMVbkavZrPToMut;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 1040);
            Controls.Add(btThoat);
            Controls.Add(btnThongKe);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(btnQLThuoc);
            Controls.Add(button3);
            Controls.Add(btnQLNV);
            Controls.Add(btnQLBN);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Button btnQLBN;
        private Button btnQLNV;
        private Button button3;
        private Button btnQLThuoc;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button btnThongKe;
        private Button btThoat;
    }
}