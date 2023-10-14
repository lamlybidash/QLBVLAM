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
    public partial class FormCapNhatThuoc : Form
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);
        public FormCapNhatThuoc()
        {
            InitializeComponent();
        }

        public void FillData(string maThuoc, string tenThuoc, string donGia, string soLuongMua)
        {
            txbMaThuoc.Text = maThuoc;
            txbTenThuoc.Text = tenThuoc;
            txbDonGia.Text = donGia;
            nmSoLuong.Text = soLuongMua;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maThuoc = txbMaThuoc.Text;
            string tenThuoc = txbTenThuoc.Text;
            string donGia = txbDonGia.Text;
            string soLuongNhap = nmSoLuong.Text;
            connect.Open();
            string query = $"update dbo.Thuoc set tenThuoc = '{tenThuoc}', donGia = '{donGia}', soLuong = soLuong + {soLuongNhap} where maThuoc = '{maThuoc}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = new SqlCommand(query, connect);
            try
            {
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thuốc thành công", "Thông báo");
                connect.Close();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Cập nhật thuốc thất bại", "Thông báo");
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
