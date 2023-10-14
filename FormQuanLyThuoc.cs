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
    public partial class FormQuanLyThuoc : Form
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);

        internal string maThuoc, tenThuoc, donGia, soLuongNhap;

        public FormQuanLyThuoc()
        {
            InitializeComponent();
        }
        public void showThuoc()
        {
            connect.Open();
            string query = "select maThuoc as 'Mã thuốc', tenThuoc as 'Tên thuốc', donGia as 'Đơn giá', soLuong as 'Số lượng' from dbo.Thuoc";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, connect);
            adapter.SelectCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgvThuoc.DataSource = dt;
            connect.Close();
        }
        public void showThuocAfterBuy()
        {
            connect.Open();
            string query = "update dbo.Thuoc set soLuong = soLuong - soLuongMua from dbo.HoaDonThuoc where dbo.Thuoc.maThuoc = dbo.HoaDonThuoc.maThuoc";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = new SqlCommand(query, connect);
            adapter.UpdateCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgvThuoc.DataSource = dt;
            connect.Close();
        }
        private void FormQuanLyThuoc_Load(object sender, EventArgs e)
        {
            showThuoc();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string getCbbSearch = cbbSearch.Text;
            string getTxbSearch = txbSearch.Text;
            if (getCbbSearch != null && getTxbSearch != null)
            {
                connect.Open();

                string sql = $"select maThuoc as 'Mã thuốc', tenThuoc as 'Tên thuốc', donGia as 'Đơn giá', soLuong as 'Số lượng' from dbo.Thuoc where {getCbbSearch} like '%{getTxbSearch}%'";
                string sql1 = $"select maThuoc as 'Mã thuốc', tenThuoc as 'Tên thuốc', donGia as 'Đơn giá', soLuong as 'Số lượng' from dbo.Thuoc where {getCbbSearch} like '{getTxbSearch}'";

                SqlDataAdapter adapter = new SqlDataAdapter();

                if (getCbbSearch == "donGia" || getCbbSearch == "soLuong")
                {
                    adapter.SelectCommand = new SqlCommand(sql1, connect);
                    adapter.SelectCommand.ExecuteNonQuery();
                }
                else
                {
                    adapter.SelectCommand = new SqlCommand(sql, connect);
                    adapter.SelectCommand.ExecuteNonQuery();
                }
                
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgvThuoc.DataSource = dt;

                connect.Close();
            }
            else
            {
                MessageBox.Show("Hay nhap du lieu de tim kiem!", "Thong bao");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá mã thuốc này không?", "Thông báo ", MessageBoxButtons.YesNo);

            string query = $"delete dbo.Thuoc where maThuoc = '{maThuoc}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = new SqlCommand(query, connect);
            try
            {
                connect.Open() ;
                adapter.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo");
                connect.Close();
                showThuoc();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connect.Open();
            FormThemThuoc ftt = new FormThemThuoc();
            ftt.ShowDialog();

            connect.Close();
            showThuoc();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            FormCapNhatThuoc fcnt = new FormCapNhatThuoc();
            fcnt.FillData(maThuoc, tenThuoc, donGia, soLuongNhap);
            fcnt.ShowDialog();
            connect.Close();

            showThuoc();
        }

        private void dtgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selected = dtgvThuoc.Rows[e.RowIndex];

                maThuoc = selected.Cells["Mã thuốc"].Value.ToString();
                tenThuoc = selected.Cells["Tên thuốc"].Value.ToString();
                donGia = selected.Cells["Đơn giá"].Value.ToString();
                soLuongNhap = selected.Cells["Số lượng"].Value.ToString();
            }
        }
    }
}
