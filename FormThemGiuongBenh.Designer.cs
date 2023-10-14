namespace QLBV
{
    partial class FormThemGiuongBenh
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
            addGB = new Button();
            huytgb = new Button();
            label1 = new Label();
            ValueMBG = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // addGB
            // 
            addGB.Location = new Point(211, 338);
            addGB.Name = "addGB";
            addGB.Size = new Size(112, 34);
            addGB.TabIndex = 0;
            addGB.Text = "Xác nhận";
            addGB.UseVisualStyleBackColor = true;
            addGB.Click += addGB_Click;
            // 
            // huytgb
            // 
            huytgb.Location = new Point(460, 338);
            huytgb.Name = "huytgb";
            huytgb.Size = new Size(112, 34);
            huytgb.TabIndex = 1;
            huytgb.Text = "Hủy";
            huytgb.UseVisualStyleBackColor = true;
            huytgb.Click += huytgb_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 123);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 2;
            label1.Text = "Nhập mã giường bệnh: ";
            // 
            // ValueMBG
            // 
            ValueMBG.Location = new Point(319, 120);
            ValueMBG.Name = "ValueMBG";
            ValueMBG.Size = new Size(326, 31);
            ValueMBG.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(239, 26);
            label3.Name = "label3";
            label3.Size = new Size(333, 48);
            label3.TabIndex = 6;
            label3.Text = "Thêm giường bệnh ";
            // 
            // FormThemGiuongBenh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(ValueMBG);
            Controls.Add(label1);
            Controls.Add(huytgb);
            Controls.Add(addGB);
            Name = "FormThemGiuongBenh";
            Text = "FormThemGiuongBenh";
            Load += FormThemGiuongBenh_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addGB;
        private Button huytgb;
        private Label label1;
        private Label label2;
        private TextBox ValueMBG;
        private TextBox ValueTT;
        private Label label3;
    }
}