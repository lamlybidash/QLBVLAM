namespace QLBV
{
    partial class FormThemBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemBenhNhan));
            MaBN = new Label();
            ValueMBN = new TextBox();
            NameBN = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ValueName = new TextBox();
            ValueID = new TextBox();
            ValueNN = new TextBox();
            ValueSDT = new TextBox();
            ValueBHYT = new TextBox();
            ValueDC = new TextBox();
            label1 = new Label();
            ValueGT = new ComboBox();
            ValueDate = new DateTimePicker();
            AddBN = new Button();
            exitFormAddBN = new Button();
            SuspendLayout();
            // 
            // MaBN
            // 
            MaBN.AutoSize = true;
            MaBN.Location = new Point(91, 86);
            MaBN.Name = "MaBN";
            MaBN.Size = new Size(84, 15);
            MaBN.TabIndex = 0;
            MaBN.Text = "Mã bệnh nhân";
            // 
            // ValueMBN
            // 
            ValueMBN.Location = new Point(228, 84);
            ValueMBN.Name = "ValueMBN";
            ValueMBN.Size = new Size(141, 23);
            ValueMBN.TabIndex = 1;
            // 
            // NameBN
            // 
            NameBN.AutoSize = true;
            NameBN.Location = new Point(91, 118);
            NameBN.Name = "NameBN";
            NameBN.Size = new Size(58, 15);
            NameBN.TabIndex = 2;
            NameBN.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 160);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 199);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 239);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 5;
            label5.Text = "Căn cước công dân";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 86);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 6;
            label6.Text = "Nghề nghiệp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(469, 125);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 7;
            label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(469, 166);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 8;
            label8.Text = "Thẻ BHYT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(469, 204);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 9;
            label9.Text = "Địa chỉ";
            // 
            // ValueName
            // 
            ValueName.Location = new Point(228, 116);
            ValueName.Name = "ValueName";
            ValueName.Size = new Size(141, 23);
            ValueName.TabIndex = 10;
            // 
            // ValueID
            // 
            ValueID.Location = new Point(228, 237);
            ValueID.Name = "ValueID";
            ValueID.Size = new Size(141, 23);
            ValueID.TabIndex = 11;
            // 
            // ValueNN
            // 
            ValueNN.Location = new Point(582, 84);
            ValueNN.Name = "ValueNN";
            ValueNN.Size = new Size(141, 23);
            ValueNN.TabIndex = 12;
            // 
            // ValueSDT
            // 
            ValueSDT.Location = new Point(582, 123);
            ValueSDT.Name = "ValueSDT";
            ValueSDT.Size = new Size(141, 23);
            ValueSDT.TabIndex = 13;
            // 
            // ValueBHYT
            // 
            ValueBHYT.Location = new Point(582, 164);
            ValueBHYT.Name = "ValueBHYT";
            ValueBHYT.Size = new Size(141, 23);
            ValueBHYT.TabIndex = 14;
            // 
            // ValueDC
            // 
            ValueDC.Location = new Point(582, 202);
            ValueDC.Name = "ValueDC";
            ValueDC.Size = new Size(141, 23);
            ValueDC.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(327, 21);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 16;
            label1.Text = "Thêm bệnh nhân";
            // 
            // ValueGT
            // 
            ValueGT.FormattingEnabled = true;
            ValueGT.Items.AddRange(new object[] { "Nam", "Nữ" });
            ValueGT.Location = new Point(228, 154);
            ValueGT.Name = "ValueGT";
            ValueGT.Size = new Size(141, 23);
            ValueGT.TabIndex = 17;
            // 
            // ValueDate
            // 
            ValueDate.Format = DateTimePickerFormat.Custom;
            ValueDate.Location = new Point(228, 196);
            ValueDate.Name = "ValueDate";
            ValueDate.Size = new Size(141, 23);
            ValueDate.TabIndex = 18;
            // 
            // AddBN
            // 
            AddBN.BackColor = Color.FromArgb(128, 255, 255);
            AddBN.Location = new Point(310, 292);
            AddBN.Name = "AddBN";
            AddBN.Size = new Size(74, 38);
            AddBN.TabIndex = 19;
            AddBN.Text = "Thêm";
            AddBN.UseVisualStyleBackColor = false;
            AddBN.Click += AddBN_Click;
            // 
            // exitFormAddBN
            // 
            exitFormAddBN.BackColor = Color.FromArgb(128, 255, 255);
            exitFormAddBN.Location = new Point(487, 292);
            exitFormAddBN.Name = "exitFormAddBN";
            exitFormAddBN.Size = new Size(74, 38);
            exitFormAddBN.TabIndex = 20;
            exitFormAddBN.Text = "Thoát";
            exitFormAddBN.UseVisualStyleBackColor = false;
            exitFormAddBN.Click += exitFormAddBN_Click;
            // 
            // FormThemBenhNhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(815, 360);
            Controls.Add(exitFormAddBN);
            Controls.Add(AddBN);
            Controls.Add(ValueDate);
            Controls.Add(ValueGT);
            Controls.Add(label1);
            Controls.Add(ValueDC);
            Controls.Add(ValueBHYT);
            Controls.Add(ValueSDT);
            Controls.Add(ValueNN);
            Controls.Add(ValueID);
            Controls.Add(ValueName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NameBN);
            Controls.Add(ValueMBN);
            Controls.Add(MaBN);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormThemBenhNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm bệnh nhân";
            Load += FormThemBenhNhan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MaBN;
        private TextBox ValueMBN;
        private Label NameBN;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox ValueName;
        private TextBox ValueID;
        private TextBox ValueNN;
        private TextBox ValueSDT;
        private TextBox ValueBHYT;
        private TextBox ValueDC;
        private Label label1;
        private ComboBox ValueGT;
        private DateTimePicker ValueDate;
        private Button AddBN;
        private Button exitFormAddBN;
    }
}