namespace QLBV
{
    partial class FormThemThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemThuoc));
            btnExit = new Button();
            btnAdd = new Button();
            label1 = new Label();
            txbTenThuoc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            NameBN = new Label();
            txbMaThuoc = new TextBox();
            lable = new Label();
            txbDonGia = new TextBox();
            nmSoLuong = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmSoLuong).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 255, 255);
            btnExit.Location = new Point(219, 367);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(85, 51);
            btnExit.TabIndex = 41;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 255);
            btnAdd.Location = new Point(144, 367);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 51);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 24);
            label1.Name = "label1";
            label1.Size = new Size(259, 39);
            label1.TabIndex = 37;
            label1.Text = "Thêm thuốc mới";
            // 
            // txbTenThuoc
            // 
            txbTenThuoc.Location = new Point(144, 147);
            txbTenThuoc.Margin = new Padding(3, 4, 3, 4);
            txbTenThuoc.Name = "txbTenThuoc";
            txbTenThuoc.Size = new Size(161, 27);
            txbTenThuoc.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 257);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 25;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 205);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 24;
            label3.Text = "Đơn giá";
            // 
            // NameBN
            // 
            NameBN.AutoSize = true;
            NameBN.Location = new Point(39, 149);
            NameBN.Name = "NameBN";
            NameBN.Size = new Size(73, 20);
            NameBN.TabIndex = 23;
            NameBN.Text = "Tên thuốc";
            // 
            // txbMaThuoc
            // 
            txbMaThuoc.Location = new Point(144, 104);
            txbMaThuoc.Margin = new Padding(3, 4, 3, 4);
            txbMaThuoc.Name = "txbMaThuoc";
            txbMaThuoc.Size = new Size(161, 27);
            txbMaThuoc.TabIndex = 22;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(39, 107);
            lable.Name = "lable";
            lable.Size = new Size(71, 20);
            lable.TabIndex = 21;
            lable.Text = "Mã thuốc";
            // 
            // txbDonGia
            // 
            txbDonGia.Location = new Point(144, 205);
            txbDonGia.Margin = new Padding(3, 4, 3, 4);
            txbDonGia.Name = "txbDonGia";
            txbDonGia.Size = new Size(161, 27);
            txbDonGia.TabIndex = 42;
            // 
            // nmSoLuong
            // 
            nmSoLuong.Location = new Point(144, 255);
            nmSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nmSoLuong.Name = "nmSoLuong";
            nmSoLuong.Size = new Size(161, 27);
            nmSoLuong.TabIndex = 43;
            // 
            // FormThemThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(406, 505);
            Controls.Add(nmSoLuong);
            Controls.Add(txbDonGia);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txbTenThuoc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NameBN);
            Controls.Add(txbMaThuoc);
            Controls.Add(lable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormThemThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm thuốc";
            ((System.ComponentModel.ISupportInitialize)nmSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnAdd;
        private Label label1;
        private TextBox txbTenThuoc;
        private Label label4;
        private Label label3;
        private Label NameBN;
        private TextBox txbMaThuoc;
        private Label lable;
        private TextBox txbDonGia;
        private NumericUpDown nmSoLuong;
    }
}