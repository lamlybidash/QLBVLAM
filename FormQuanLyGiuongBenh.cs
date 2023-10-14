using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QLBV
{
    public partial class FormQuanLyGiuongBenh : Form
    {
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(cnn);

        public string maGiuong, tinhTrang;

        public FormQuanLyGiuongBenh()
        {
            InitializeComponent();
        }

        public void reloadGiuong()
        {
            connect.Open();

            string sqlcmd1 = $"SELECT maGiuong, maBA FROM dbo.GiuongBenh WHERE tinhTrang = 1";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sqlcmd1, connect);
            adapter.SelectCommand.ExecuteNonQuery();


            DataTable dtGiuongBan = new DataTable();
            adapter.Fill(dtGiuongBan);

            DateTime dateNow = DateTime.Now;
            DateTime d = DateTime.Now;

            for (int i = 0; i < dtGiuongBan.Rows.Count; i++)
            {
                string sqlcmd2 = $"SELECT ngayRa FROM dbo.BenhAn WHERE maBA = '{dtGiuongBan.Rows[i][1]}'";
                adapter.SelectCommand = new SqlCommand(sqlcmd2, connect);
                adapter.SelectCommand.ExecuteNonQuery();

                DataTable dtNgayRa = new DataTable();

                adapter.Fill(dtNgayRa);

                if (dateNow > (DateTime)dtNgayRa.Rows[0][0])
                {
                    string sqlcmd3 = $"UPDATE dbo.GiuongBenh SET tinhTrang = 0 WHERE maGiuong = '{dtGiuongBan.Rows[i][0]}'";
                    adapter.UpdateCommand = new SqlCommand(sqlcmd3, connect);
                    adapter.UpdateCommand.ExecuteNonQuery();
                }
            }

            connect.Close();
        }

        public void HienThi()
        {

            connect.Open();

            string sqlcmd = "select maGiuong as 'Mã giường', tinhTrang as 'Tình trạng' from dbo.GiuongBenh";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sqlcmd, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGB.DataSource = dt;

            connect.Close();
        }

        private void FormQuanLyGiuongBenh_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void thoatgb_Click(object sender, EventArgs e) //thoat
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e) // xoa
        {
            if (dataGB.SelectedRows.Count >= 0)
            {
                try
                {
                    string mgx = dataGB.SelectedRows[0].Cells[0].Value.ToString();
                    string querry = $"delete dbo.GiuongBenh where maGiuong = '{mgx}'";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = new SqlCommand(querry, connect);
                    connect.Open();
                    adapter.DeleteCommand.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Xóa giường bệnh thành công !", "Thông báo ");
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa giường bệnh thất bại !", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng chứa mã giường bệnh !", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e) //reload
        {
            reloadGiuong();
            HienThi();
        }

        private void dataGB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selected = dataGB.Rows[e.RowIndex];

                maGiuong = selected.Cells["maGiuong"].Value.ToString();
                tinhTrang = selected.Cells["tinhTrang"].Value.ToString();
            }
        }


        private void tim_Click(object sender, EventArgs e)
        {
            connect.Open();

            string getcbbtim = cbbtim.Text;
            string gettxttim = txttim.Text;

            string querry = $"select maGiuong as 'Mã giường', tinhTrang as 'Tình trạng' from [dbo].[GiuongBenh] where {getcbbtim} like '%{gettxttim}%' ";

            if (getcbbtim != "" && gettxttim != "")
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(querry, connect);
                adapter.SelectCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGB.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Hãy nhập dữ liêu để tìm kiếm !", "Thông báo ");
            }

            connect.Close();

        }

        private void themgb_Click(object sender, EventArgs e)
        {
            FormThemGiuongBenh tgb = new FormThemGiuongBenh();
            tgb.ShowDialog();
        }
    }
}

