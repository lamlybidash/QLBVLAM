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
    public partial class FormQuanLyBenhNhan : Form
    {
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection conect = new SqlConnection(cnn);

        public string maBN, tenBN, gioiTinh, cccd, sdt;

        public FormQuanLyBenhNhan()
        {
            InitializeComponent();
        }

        public void show()
        {
            string sql = "select * from dbo.BenhNhan";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, conect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgvBN.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemBenhNhan formThemBenhNhan = new FormThemBenhNhan();
            formThemBenhNhan.ShowDialog();
            conect.Open();
            show();
            conect.Close();
        }

        private void FormQuanLyBenhNhan_Load(object sender, EventArgs e)
        {
            conect.Open();
            show();
            conect.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maBN = dtgvBN.SelectedRows[0].Cells[0].Value.ToString();
            FormUpDateBenhNhan formUpDateBenhNhan = new FormUpDateBenhNhan(maBN);
            formUpDateBenhNhan.ShowDialog();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conect.Open();
            string getCbbSearch = cbbSearch.Text;
            string gettxbSearch = txbSearch.Text;
            string sql = $"select * from dbo.BenhNhan where {getCbbSearch} like '%{gettxbSearch}%'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, conect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgvBN.DataSource = dt;
            conect.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvBN.SelectedRows.Count > 0)
            {
                conect.Open();
                string maBN_xoa = dtgvBN.SelectedRows[0].Cells[0].Value.ToString();


                string query = $"delete dbo.BenhNhan where maBN = '{maBN_xoa}'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = new SqlCommand(query, conect);

                string query1 = $"delete dbo.BenhAn where maBN = '{maBN_xoa}'";
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                adapter1.DeleteCommand = new SqlCommand(query1, conect);
                FormQuanLyHoaDon quanLyHoaDon = new FormQuanLyHoaDon(maBN);

                quanLyHoaDon.xoaHDtheoBN(maBN_xoa);
                try
                {
                    adapter.DeleteCommand.ExecuteNonQuery();
                    adapter1.DeleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công", "Thông báo");
                    show();
                    conect.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chọn dòng để xóa!", "Thông báo");
                conect.Close();
            }
        }

        private void btnBenhAn_Click(object sender, EventArgs e)
        {
            FormQuanLyBenhAn fqlba = new FormQuanLyBenhAn();
            fqlba.setMaBN(maBN);
            fqlba.ShowDialog();

        }

        private void dtgvBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selected = dtgvBN.Rows[e.RowIndex];

                maBN = selected.Cells["maBN"].Value.ToString();
                tenBN = selected.Cells["hoTen"].Value.ToString();
                gioiTinh = selected.Cells["gioiTinh"].Value.ToString();
                cccd = selected.Cells["cccd"].Value.ToString();
                sdt = selected.Cells["sdt"].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            conect.Close();
            this.Close();

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FormQuanLyHoaDon formQuanLyHoaDon = new FormQuanLyHoaDon(maBN);
            formQuanLyHoaDon.ShowDialog();
        }

        private void Reloadform_Click(object sender, EventArgs e)
        {
            conect.Open();
            show();
            conect.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
