using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLBV
{
    public partial class FormDoiMK : Form
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void FormTTCaNhan_Load(object sender, EventArgs e)
        {
            string userName = FormDangNhap.userName;
            txbUserName.Text = userName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userName = FormDangNhap.userName;
            string pass = FormDangNhap.pass;
            string getPass = txbPass.Text;
            string getNewPass = txbNewPass.Text;
            string getReNewPass = txbReNewPass.Text;

            txbUserName.Text = userName;
            if (getPass == pass && getNewPass != "" && getNewPass == getReNewPass && getNewPass != getPass)
            {
                connect.Open();

                string query = $"update [dbo].[TaiKhoan] set matKhau = '{getReNewPass}' where tenDangNhap = '{userName}'";

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = new SqlCommand(query, connect);
                try
                {
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                    connect.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    connect.Close();
                }
            }
            else if (getPass == "")
                MessageBox.Show("Yêu cầu bạn nhập mật khẩu!", "Thông báo");
            else if (getPass != pass)
                MessageBox.Show("Mật khẩu không đúng!", "Thông báo");
            else if (getNewPass == "")
                MessageBox.Show("Yêu cầu bạn nhập mật khẩu mới!", "Thông báo");
            else if (getReNewPass == "")
                MessageBox.Show("Yêu cầu bạn xác minh mật khẩu mới!", "Thông báo");
            else if (getNewPass != getReNewPass)
                MessageBox.Show("Mật khẩu mới không trùng nhau!", "Thông báo");
            else if (getNewPass == getPass)
                MessageBox.Show("Mật khẩu mới không được trùng nhau mật khẩu hiện tại!", "Thông báo");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
