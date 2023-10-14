using DocumentFormat.OpenXml.InkML;
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
    public partial class FormThemBenhAn : Form
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);
        internal string maBN;
        internal string maGiuong = "";
        internal string maBA;
        internal string chuanDoan;
        internal string tinhTrang;
        internal string ngayVao;
        internal string ngayRa;
        internal string maNV;


        public FormThemBenhAn()
        {
            InitializeComponent();
        }
        public FormThemBenhAn(string maBN)
        {
            InitializeComponent();
            this.maBN = maBN;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbMaBA.Clear();
            txbChuanDoan.Clear();
            txbTinhTrang.Clear();
            dtpkNgayVao.Text = null;
            dtpkNgayRa.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            maBA = txbMaBA.Text;
            chuanDoan = txbChuanDoan.Text;
            tinhTrang = txbTinhTrang.Text;
            ngayVao = dtpkNgayVao.Value.ToString("yyyy/MM/dd");
            ngayRa = dtpkNgayRa.Value.ToString("yyyy/MM/dd");
            maNV = cbbMaNV.Text;

            if (maBA == "")
                MessageBox.Show("Nhập mã bệnh án!", "Thông báo");
            else if(chuanDoan== "")
                MessageBox.Show("Nhập thông tin chuẩn đoán!", "Thông báo");
            else if(tinhTrang=="")
                MessageBox.Show("Nhập tình trạng ra viện!", "Thông báo");
            else if(maNV=="")
                MessageBox.Show("Chọn mã nhân viên!", "Thông báo");
            else
            {

                string query = $"insert into dbo.BenhAn values('{maBA}', '{ngayVao}', '{ngayRa}', '{chuanDoan}', '{tinhTrang}', '{maBN}', '{maNV}', '{maGiuong}')";
                string sqlcmd = $"UPDATE dbo.GiuongBenh SET tinhTrang = 1, maBA = '{maBA}' WHERE maGiuong = '{maGiuong}' ";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(query, connect);
                try
                {
                    connect.Open();
                    adapter.InsertCommand.ExecuteNonQuery();

                    adapter.UpdateCommand = new SqlCommand(sqlcmd, connect);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo");

                    connect.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo");
                    connect.Close();
                }
            }

        }

        private void FormThemBenhAn_Load(object sender, EventArgs e)
        {
            BindingDataToCbb();
            BindingGiuongBenhToCbb();
            connect.Open();
            string query = $"select * from dbo.BenhNhan where maBN = '{maBN}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, connect);
            try
            {
                adapter.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                lbMaBN.Text = dt.Rows[0]["maBN"].ToString();
                lbTenBN.Text = dt.Rows[0]["hoTen"].ToString();
                lbGTBN.Text = dt.Rows[0]["gioiTinh"].ToString();
                lbCCCD.Text = dt.Rows[0]["cccd"].ToString();
                lbSDTBN.Text = dt.Rows[0]["sdt"].ToString();
                connect.Close();
            }
            catch (Exception ex)
            {
                connect.Close();
            }
        }
        public void BindingDataToCbb()
        {
            connect.Open();
            string query = "select maNV from dbo.NhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, connect);
            adapter.SelectCommand.ExecuteNonQuery();

            DataTable dtNV = new DataTable();
            adapter.Fill(dtNV);

            for (int i = 0; i < dtNV.Rows.Count; i++)
            {
                string maNV = dtNV.Rows[i][0].ToString();
                cbbMaNV.Items.Add(maNV);
            }
            connect.Close();
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Open();
            string getMaNV = cbbMaNV.SelectedItem.ToString();

            string query = $"select hoTen, gioiTinh, chucVu, sdt from dbo.NhanVien where maNV = '{getMaNV}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dtNV = new DataTable();
            adapter.Fill(dtNV);

            for (int i = 0; i < dtNV.Rows.Count; i++)
            {
                lbTenNV.Text = dtNV.Rows[i][0].ToString();
                lbGTNV.Text = dtNV.Rows[i][1].ToString();
                lbChucVu.Text = dtNV.Rows[i][2].ToString();
                lbSDTNV.Text = dtNV.Rows[i][3].ToString();
            }
            connect.Close();
        }

        public void BindingGiuongBenhToCbb()
        {
            connect.Open();
            string query = "select maGiuong from dbo.GiuongBenh where tinhTrang = '0'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, connect);
            adapter.SelectCommand.ExecuteNonQuery();

            DataTable dtGiuongBenh = new DataTable();
            adapter.Fill(dtGiuongBenh);

            for (int i = 0; i < dtGiuongBenh.Rows.Count; i++)
            {
                string maGiuong = dtGiuongBenh.Rows[i][0].ToString();
                cbbMaGiuong.Items.Add(maGiuong);
            }
            connect.Close();
        }

        private void cbbMaGiuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            maGiuong = cbbMaGiuong.SelectedItem.ToString();
        }
    }
}
