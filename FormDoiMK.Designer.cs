namespace QLBV
{
    partial class FormDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMK));
            label1 = new Label();
            txbUserName = new TextBox();
            txbPass = new TextBox();
            label2 = new Label();
            txbNewPass = new TextBox();
            label3 = new Label();
            txbReNewPass = new TextBox();
            label4 = new Label();
            label6 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 57);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(251, 57);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(125, 27);
            txbUserName.TabIndex = 1;
            // 
            // txbPass
            // 
            txbPass.Location = new Point(251, 124);
            txbPass.Name = "txbPass";
            txbPass.PasswordChar = '*';
            txbPass.Size = new Size(125, 27);
            txbPass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 124);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // txbNewPass
            // 
            txbNewPass.Location = new Point(251, 183);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.PasswordChar = '*';
            txbNewPass.Size = new Size(125, 27);
            txbNewPass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 183);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu mới";
            // 
            // txbReNewPass
            // 
            txbReNewPass.Location = new Point(251, 245);
            txbReNewPass.Name = "txbReNewPass";
            txbReNewPass.PasswordChar = '*';
            txbReNewPass.Size = new Size(125, 27);
            txbReNewPass.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 245);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 6;
            label4.Text = "Nhập lại mật khẩu mới";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(192, 9);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 10;
            label6.Text = "Đổi mật khẩu";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(121, 328);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(283, 328);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FormDoiMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(519, 444);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(txbReNewPass);
            Controls.Add(label4);
            Controls.Add(txbNewPass);
            Controls.Add(label3);
            Controls.Add(txbPass);
            Controls.Add(label2);
            Controls.Add(txbUserName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDoiMK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            Load += FormTTCaNhan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbUserName;
        private TextBox txbPass;
        private Label label2;
        private TextBox txbNewPass;
        private Label label3;
        private TextBox txbReNewPass;
        private Label label4;
        private Label label6;
        private Button btnUpdate;
        private Button btnExit;
    }
}