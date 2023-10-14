namespace QLBV
{
    partial class FormUpDateBenhNhan
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
            button1 = new Button();
            button2 = new Button();
            MaBN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            NameBN = new TextBox();
            SDTBN = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            DateBN = new DateTimePicker();
            GTBN = new ComboBox();
            macccd = new TextBox();
            nnBn = new TextBox();
            bhytbn = new TextBox();
            diachibn = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Location = new Point(1027, 655);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Sửa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Location = new Point(1194, 655);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // MaBN
            // 
            MaBN.Location = new Point(143, 311);
            MaBN.Name = "MaBN";
            MaBN.Size = new Size(234, 23);
            MaBN.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 319);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Mã bệnh nhân";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(462, 22);
            label2.Name = "label2";
            label2.Size = new Size(383, 37);
            label2.TabIndex = 4;
            label2.Text = "Chỉnh sửa thông tin bệnh nhân";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 402);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Họ và tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 506);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 311);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 7;
            label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(496, 402);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 8;
            label6.Text = "CCCD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(496, 506);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 9;
            label7.Text = "Nghề Nghiệp";
            // 
            // NameBN
            // 
            NameBN.Location = new Point(143, 402);
            NameBN.Name = "NameBN";
            NameBN.Size = new Size(234, 23);
            NameBN.TabIndex = 10;
            // 
            // SDTBN
            // 
            SDTBN.Location = new Point(994, 311);
            SDTBN.Name = "SDTBN";
            SDTBN.Size = new Size(234, 23);
            SDTBN.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(907, 509);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 17;
            label8.Text = "Địa chỉ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(907, 405);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 16;
            label9.Text = "BHYT";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(907, 314);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 15;
            label10.Text = "Số điện thoại";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(143, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1085, 191);
            dataGridView1.TabIndex = 21;
            // 
            // DateBN
            // 
            DateBN.Location = new Point(583, 311);
            DateBN.Name = "DateBN";
            DateBN.Size = new Size(200, 23);
            DateBN.TabIndex = 22;
            // 
            // GTBN
            // 
            GTBN.FormattingEnabled = true;
            GTBN.Items.AddRange(new object[] { "Nam", "Nữ" });
            GTBN.Location = new Point(143, 498);
            GTBN.Name = "GTBN";
            GTBN.Size = new Size(234, 23);
            GTBN.TabIndex = 23;
            // 
            // macccd
            // 
            macccd.Location = new Point(583, 402);
            macccd.Name = "macccd";
            macccd.Size = new Size(234, 23);
            macccd.TabIndex = 24;
            // 
            // nnBn
            // 
            nnBn.Location = new Point(583, 506);
            nnBn.Name = "nnBn";
            nnBn.Size = new Size(234, 23);
            nnBn.TabIndex = 25;
            // 
            // bhytbn
            // 
            bhytbn.Location = new Point(994, 405);
            bhytbn.Name = "bhytbn";
            bhytbn.Size = new Size(234, 23);
            bhytbn.TabIndex = 26;
            // 
            // diachibn
            // 
            diachibn.Location = new Point(994, 509);
            diachibn.Name = "diachibn";
            diachibn.Size = new Size(234, 23);
            diachibn.TabIndex = 27;
            // 
            // FormUpDateBenhNhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1324, 753);
            Controls.Add(diachibn);
            Controls.Add(bhytbn);
            Controls.Add(nnBn);
            Controls.Add(macccd);
            Controls.Add(GTBN);
            Controls.Add(DateBN);
            Controls.Add(dataGridView1);
            Controls.Add(SDTBN);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(NameBN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MaBN);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormUpDateBenhNhan";
            Text = "FormUpDateBenhNhan";
            Load += FormUpDateBenhNhan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox MaBN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox NameBN;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox SDTBN;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dataGridView1;
        private DateTimePicker DateBN;
        private ComboBox GTBN;
        private TextBox macccd;
        private TextBox nnBn;
        private TextBox bhytbn;
        private TextBox diachibn;
    }
}