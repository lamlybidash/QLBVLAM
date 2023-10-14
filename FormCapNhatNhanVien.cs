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
    public partial class FormCapNhatNhanVien : Form
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);

        public FormCapNhatNhanVien()
        {
            InitializeComponent();
        }
        public void FillData(string maNV, string hoTen, string gioiTinh, string ngaySinh, string chucVu, string sdt, string quequan, string diaChi)
        {
            txbMaNV.Text = maNV;
            txbHoTen.Text = hoTen;
            cbbGT.Text = gioiTinh;
            dtpkNgaySinh.Text = ngaySinh;
            txbChucVu.Text = chucVu;
            txbSDT.Text = sdt;
            txbQueQuan.Text = quequan;
            txbDiaChi.Text = diaChi;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maNV = txbMaNV.Text;
            string hoTen = txbHoTen.Text;
            string gioiTinh = cbbGT.Text;
            string ngaySinh = dtpkNgaySinh.Value.ToString("yyyy/MM/dd");
            string chucVu = txbChucVu.Text;
            string sdt = txbSDT.Text;
            string queQuan = txbQueQuan.Text;
            string diaChi = txbDiaChi.Text;

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
            else
            {
                connect.Open();

                string query = $"update dbo.NhanVien set hoTen = '{hoTen}', gioiTinh= '{gioiTinh}', " +
                    $"ngaySinh = '{ngaySinh}', chucVu = '{chucVu}', sdt= '{sdt}', queQuan = '{queQuan}', diaChi = '{diaChi}' where maNV = '{maNV}'";

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = new SqlCommand(query, connect);
                try
                {
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    connect.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbHoTen.Text = null;
            cbbGT.Text = null;
            dtpkNgaySinh.Text = null;
            txbChucVu.Text = null;
            txbSDT.Text = null;
            txbQueQuan.Text = null;
            txbDiaChi.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
