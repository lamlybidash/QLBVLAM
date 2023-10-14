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

namespace QLBV
{
    public partial class FormDangNhap : Form
    {

        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);

        public static string userName, pass, loaiTaiKhoan;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Open();

            userName = txbUserName.Text;
            pass = txbPass.Text;
            FormThemNhanVien formThemNhanVien = new FormThemNhanVien();
            pass = formThemNhanVien.MaHoaPass(pass);
            MessageBox.Show(pass);
            string query = "select tenDangNhap, matKhau, loaiTaiKhoan from [dbo].[TaiKhoan]";

            SqlCommand cmd = new SqlCommand(query, connect);

            DbDataReader dbDataReader = cmd.ExecuteReader();
            bool check = false;
            while (dbDataReader.Read())
            {
                loaiTaiKhoan = dbDataReader["loaiTaiKhoan"].ToString();
                string getUserName = dbDataReader["tenDangNhap"].ToString();
                string getPass = dbDataReader["matKhau"].ToString();

                if (userName == getUserName && pass == getPass)
                {
                    FormTrangChu trangchu = new FormTrangChu();
                    trangchu.ShowDialog();
                    check = true;
                    break;
                }
            }

            if (check == false)
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo");
            }

            connect.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
