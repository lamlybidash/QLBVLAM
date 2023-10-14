namespace QLBV
{
    partial class FormCapNhatThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapNhatThuoc));
            nmSoLuong = new NumericUpDown();
            txbDonGia = new TextBox();
            btnExit = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            txbTenThuoc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            NameBN = new Label();
            txbMaThuoc = new TextBox();
            lable = new Label();
            ((System.ComponentModel.ISupportInitialize)nmSoLuong).BeginInit();
            SuspendLayout();
            // 
            // nmSoLuong
            // 
            nmSoLuong.Location = new Point(169, 260);
            nmSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nmSoLuong.Name = "nmSoLuong";
            nmSoLuong.Size = new Size(161, 27);
            nmSoLuong.TabIndex = 54;
            // 
            // txbDonGia
            // 
            txbDonGia.Location = new Point(169, 211);
            txbDonGia.Margin = new Padding(3, 4, 3, 4);
            txbDonGia.Name = "txbDonGia";
            txbDonGia.Size = new Size(161, 27);
            txbDonGia.TabIndex = 53;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 255, 255);
            btnExit.Location = new Point(245, 372);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(69, 51);
            btnExit.TabIndex = 52;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnUpdate.Location = new Point(169, 372);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(65, 51);
            btnUpdate.TabIndex = 51;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(380, 39);
            label1.TabIndex = 50;
            label1.Text = "Cập nhật thông tin thuốc";
            // 
            // txbTenThuoc
            // 
            txbTenThuoc.Location = new Point(169, 151);
            txbTenThuoc.Margin = new Padding(3, 4, 3, 4);
            txbTenThuoc.Name = "txbTenThuoc";
            txbTenThuoc.Size = new Size(161, 27);
            txbTenThuoc.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 261);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 48;
            label4.Text = "Số lượng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 207);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 47;
            label3.Text = "Đơn giá";
            // 
            // NameBN
            // 
            NameBN.AutoSize = true;
            NameBN.Location = new Point(27, 151);
            NameBN.Name = "NameBN";
            NameBN.Size = new Size(73, 20);
            NameBN.TabIndex = 46;
            NameBN.Text = "Tên thuốc";
            // 
            // txbMaThuoc
            // 
            txbMaThuoc.Location = new Point(169, 109);
            txbMaThuoc.Margin = new Padding(3, 4, 3, 4);
            txbMaThuoc.Name = "txbMaThuoc";
            txbMaThuoc.ReadOnly = true;
            txbMaThuoc.Size = new Size(161, 27);
            txbMaThuoc.TabIndex = 45;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(27, 109);
            lable.Name = "lable";
            lable.Size = new Size(71, 20);
            lable.TabIndex = 44;
            lable.Text = "Mã thuốc";
            // 
            // FormCapNhatThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(395, 451);
            Controls.Add(nmSoLuong);
            Controls.Add(txbDonGia);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(txbTenThuoc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NameBN);
            Controls.Add(txbMaThuoc);
            Controls.Add(lable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCapNhatThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật thuốc";
            ((System.ComponentModel.ISupportInitialize)nmSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nmSoLuong;
        private TextBox txbDonGia;
        private Button btnExit;
        private Button btnUpdate;
        private Label label1;
        private TextBox txbTenThuoc;
        private Label label4;
        private Label label3;
        private Label NameBN;
        private TextBox txbMaThuoc;
        private Label lable;
    }
}