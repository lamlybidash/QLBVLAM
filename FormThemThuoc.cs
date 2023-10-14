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
    public partial class FormThemThuoc : Form
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);

        public FormThemThuoc()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maThuoc = txbMaThuoc.Text;
            string tenThuoc = txbTenThuoc.Text;
            string donGia = txbDonGia.Text;
            string soLuong = nmSoLuong.Text;
            if (maThuoc == "")
                MessageBox.Show("Nhập mã thuốc!", "Thông báo");
            else if (tenThuoc == "")
                MessageBox.Show("Nhập tên thuốc!", "Thông báo");
            else if (donGia == "")
                MessageBox.Show("Nhập đơn giá thuốc!", "Thông báo");
            else if (soLuong == "")
                MessageBox.Show("Nhập số lượng thuốc!", "Thông báo");
            else
            {
                connect.Open();

                string query = $"insert into dbo.Thuoc " +
                    $"values('{maThuoc}', '{tenThuoc}', '{donGia}', '{soLuong}')";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(query, connect);

                try
                {
                    adapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    connect.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                    connect.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
