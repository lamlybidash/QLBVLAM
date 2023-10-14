using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBV
{
    public partial class FormThemNhanVien : Form
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);

        public FormThemNhanVien()
        {
            InitializeComponent();
        }


        public string MaHoaPass(string s)
        {
            int i = 0;
            char[] c = s.ToCharArray();
            int[] ascill = new int[c.Length];
            for (i = 0; i < c.Length; i++) 
            {
                ascill[i] = (int)c[i];
            }

            string mahoa="";
            for (i = c.Length-1; i >=0 ; i--)
            {
                mahoa += $"{ascill[i]}";
            }
            return mahoa;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maNV = txbMaNV.Text;
            string hoTen = txbHoTen.Text;
            string gioiTinh = cbbGT.Text;
            string ngaySinh = dtpkNgaySinh.Value.ToString("yyyy/MM/dd");
            string chucVu = txbChucVu.Text;
            string sdt = txbSDT.Text;
            string queQuan = txbQueQuan.Text;
            string diaChi = txbDiaChi.Text;
            string tenDangNhap = txbUserName.Text;
            string matKhau = txbPass.Text;
            string loaiTaiKhoan = CbbLoaiTK.Text;

            if (maNV == "")
                MessageBox.Show("Nhập mã nhân viên!", "Thông báo");
            else if (hoTen == "")
                MessageBox.Show("Nhập họ tên!", "Thông báo");
            else if (gioiTinh == "")
                MessageBox.Show("Nhập giới tính!", "Thông báo");
            else if (chucVu == "")
                MessageBox.Show("Nhập chức vụ!", "Thông báo");
            else if (sdt == "")
                MessageBox.Show("Nhập sđt!", "Thông báo");
            else if (queQuan == "")
                MessageBox.Show("Nhập quê quán!", "Thông báo");
            else if (diaChi == "")
                MessageBox.Show("Nhập địa chỉ!", "Thông báo");
            else if (tenDangNhap == "")
                MessageBox.Show("Nhập tên đăng nhập!", "Thông báo");
            else if (matKhau == "")
                MessageBox.Show("Nhập mật khẩu!", "Thông báo");
            else if (loaiTaiKhoan == "")
                MessageBox.Show("Chọn loại tài khoản!", "Thông báo");
            else
            {
                try
                {
                    connect.Open();

                    string query1 = $"insert into dbo.NhanVien " +
                    $"values('{maNV}', '{hoTen}', '{gioiTinh}', '{ngaySinh}', '{chucVu}', '{sdt}', '{queQuan}', '{diaChi}')";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand(query1, connect);
                    adapter.InsertCommand.ExecuteNonQuery();
                    matKhau = MaHoaPass(matKhau);
                    string query2 = $"insert into dbo.TaiKhoan(tenDangNhap, matKhau, loaiTaiKhoan, maNV)" +
                        $"values('{tenDangNhap}', '{matKhau}', '{loaiTaiKhoan}', '{maNV}')";
                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    adapter1.InsertCommand = new SqlCommand(query2, connect);
                    adapter1.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
                    connect.Close();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm nhân viên không thành công!", "Thông báo");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbMaNV.Text = null;
            txbHoTen.Text = null;
            cbbGT.Text = null;
            dtpkNgaySinh.Text = null;
            txbChucVu.Text = null;
            txbSDT.Text = null;
            txbQueQuan.Text = null;
            txbDiaChi.Text = null;
            txbUserName.Text = null;
            txbPass.Text = null;
            CbbLoaiTK.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
