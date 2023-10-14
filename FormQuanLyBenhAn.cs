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
    public partial class FormQuanLyBenhAn : Form
    {
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection conect = new SqlConnection(cnn);

        public string maBN, maNV, maBA;

        public FormQuanLyBenhAn()
        {
            InitializeComponent();
        }
        public FormQuanLyBenhAn(string maBN)
        {
            InitializeComponent();
            this.maBN = maBN;
        }
        public void setMaBN(string setMaBN)
        {
            maBN = setMaBN;
        }

        public void BindingDataToCbb()
        {
            conect.Open();
            string query = $"select maBA from dbo.BenhAn where maBN = '{maBN}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, conect);
            adapter.SelectCommand.ExecuteNonQuery();

            DataTable dtBA = new DataTable();
            adapter.Fill(dtBA);

            for (int i = 0; i < dtBA.Rows.Count; i++)
            {
                string maBA = dtBA.Rows[i][0].ToString();
                cbbBA.Items.Add(maBA);
            }
            conect.Close();
        }

        void loadListBA()
        {
            BindingDataToCbb();
            conect.Open();
            string query = $"select * from dbo.BenhNhan where maBN = '{maBN}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, conect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dtBN = new DataTable();
            adapter.Fill(dtBN);

            lbMaBN.Text = dtBN.Rows[0]["maBN"].ToString();
            lbTenBN.Text = dtBN.Rows[0]["hoTen"].ToString();
            lbGTBN.Text = dtBN.Rows[0]["gioiTinh"].ToString();
            lbCCCD.Text = dtBN.Rows[0]["cccd"].ToString();
            lbSDTBN.Text = dtBN.Rows[0]["sdt"].ToString();
            conect.Close();
        }

        private void FormQuanLyBenhAn_Load(object sender, EventArgs e)
        {
            loadListBA();
        }

        private void cbbBA_SelectedIndexChanged(object sender, EventArgs e)
        {
            conect.Open();
            string getMaBA = cbbBA.SelectedItem.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter();

            string query = $"select maNV from dbo.BenhAn where maBA = '{getMaBA}'";
            adapter.SelectCommand = new SqlCommand(query, conect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dtMaNV = new DataTable();
            adapter.Fill(dtMaNV);

            string maNV = dtMaNV.Rows[0][0].ToString();
            string query1 = $"select * from dbo.NhanVien where maNV = '{maNV}'";
            adapter.SelectCommand = new SqlCommand(query1, conect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dtNV = new DataTable();
            adapter.Fill(dtNV);

            lbMaNV.Text = dtNV.Rows[0]["maNV"].ToString();
            lbTenNV.Text = dtNV.Rows[0]["hoTen"].ToString();
            lbGTNV.Text = dtNV.Rows[0]["gioiTinh"].ToString();
            lbChucVu.Text = dtNV.Rows[0]["chucVu"].ToString();
            lbSDTNV.Text = dtNV.Rows[0]["sdt"].ToString();

            string query2 = $"select chanDoan, tinhTrangRaVien, maGiuong, ngayVao, ngayRa from dbo.BenhAn where maBA = '{getMaBA}'";
            adapter.SelectCommand = new SqlCommand(query2, conect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dtBA = new DataTable();
            adapter.Fill(dtBA);

            lbChuanDoan.Text = dtBA.Rows[0]["chanDoan"].ToString();
            lbTinhTrang.Text = dtBA.Rows[0]["tinhTrangRaVien"].ToString();
            lbMaGiuong.Text = dtBA.Rows[0]["maGiuong"].ToString();
            DateTime d = DateTime.Now;
            d = (DateTime)dtBA.Rows[0]["ngayVao"];
            lbNgayVao.Text = d.ToString("dd/MM/yyyy");
            d = (DateTime)dtBA.Rows[0]["ngayRa"];
            lbNgayRa.Text = d.ToString("dd/MM/yyyy");

            conect.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemBenhAn ftba = new FormThemBenhAn(maBN);
            FormQuanLyGiuongBenh fqlgb = new FormQuanLyGiuongBenh();
            fqlgb.reloadGiuong();
            ftba.ShowDialog();
            loadListBA();


        }
    }
}
