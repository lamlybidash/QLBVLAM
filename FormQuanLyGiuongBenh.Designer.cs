namespace QLBV
{
    partial class FormQuanLyGiuongBenh
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
            dataGB = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            tim = new Button();
            button3 = new Button();
            themgb = new Button();
            txttim = new TextBox();
            thoatgb = new Button();
            cbbtim = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGB).BeginInit();
            SuspendLayout();
            // 
            // dataGB
            // 
            dataGB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGB.Location = new Point(39, 95);
            dataGB.Margin = new Padding(2);
            dataGB.Name = "dataGB";
            dataGB.RowHeadersWidth = 62;
            dataGB.RowTemplate.Height = 33;
            dataGB.Size = new Size(601, 293);
            dataGB.TabIndex = 0;
            dataGB.CellContentClick += dataGB_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(368, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 32);
            label1.TabIndex = 1;
            label1.Text = "Quản lý giường bệnh";
            // 
            // button1
            // 
            button1.Location = new Point(39, 21);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(108, 36);
            button1.TabIndex = 2;
            button1.Text = "Reload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tim
            // 
            tim.Location = new Point(898, 21);
            tim.Margin = new Padding(2);
            tim.Name = "tim";
            tim.Size = new Size(79, 79);
            tim.TabIndex = 3;
            tim.Text = "Tìm kiếm";
            tim.UseVisualStyleBackColor = true;
            tim.Click += tim_Click;
            // 
            // button3
            // 
            button3.Location = new Point(750, 208);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(202, 37);
            button3.TabIndex = 4;
            button3.Text = "Xóa giường bệnh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // themgb
            // 
            themgb.Location = new Point(750, 135);
            themgb.Margin = new Padding(2);
            themgb.Name = "themgb";
            themgb.Size = new Size(202, 37);
            themgb.TabIndex = 4;
            themgb.Text = "Thêm giường bệnh";
            themgb.UseVisualStyleBackColor = true;
            themgb.Click += themgb_Click;
            // 
            // txttim
            // 
            txttim.Location = new Point(750, 77);
            txttim.Margin = new Padding(2);
            txttim.Name = "txttim";
            txttim.Size = new Size(129, 23);
            txttim.TabIndex = 5;
            // 
            // thoatgb
            // 
            thoatgb.Location = new Point(750, 302);
            thoatgb.Margin = new Padding(2);
            thoatgb.Name = "thoatgb";
            thoatgb.Size = new Size(202, 86);
            thoatgb.TabIndex = 6;
            thoatgb.Text = "Thoát";
            thoatgb.UseVisualStyleBackColor = true;
            thoatgb.Click += thoatgb_Click;
            // 
            // cbbtim
            // 
            cbbtim.FormattingEnabled = true;
            cbbtim.Items.AddRange(new object[] { "maGiuong", "tinhTrang" });
            cbbtim.Location = new Point(750, 44);
            cbbtim.Margin = new Padding(2);
            cbbtim.Name = "cbbtim";
            cbbtim.Size = new Size(129, 23);
            cbbtim.TabIndex = 8;
            // 
            // FormQuanLyGiuongBenh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 420);
            Controls.Add(cbbtim);
            Controls.Add(thoatgb);
            Controls.Add(txttim);
            Controls.Add(themgb);
            Controls.Add(button3);
            Controls.Add(tim);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGB);
            Margin = new Padding(2);
            Name = "FormQuanLyGiuongBenh";
            Text = "FormQuanLyGiuongBenh";
            Load += FormQuanLyGiuongBenh_Load;
            ((System.ComponentModel.ISupportInitialize)dataGB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGB;
        private Label label1;
        private Button button1;
        private Button tim;
        private Button button3;
        private Button themgb;
        private TextBox txttim;
        private Button thoatgb;
        private ComboBox cbbtim;
    }
}