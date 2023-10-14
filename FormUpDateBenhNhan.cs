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

    public partial class FormUpDateBenhNhan : Form
    {
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(cnn);
        internal string maBN, hoTen, gioiTinh, cccd, ngheNghiep, sdt, bhyt, diaChi;
        internal string date;
        public FormUpDateBenhNhan()
        {
            InitializeComponent();
        }

        private void FormUpDateBenhNhan_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng nhập thông tin", "Thông báo");
            connect.Open();
            string sql = "select * from dbo.BenhNhan";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public FormUpDateBenhNhan(string MBN)
        {
            InitializeComponent();
            maBN = MBN;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            maBN = MaBN.Text;
            hoTen = NameBN.Text;
            gioiTinh = GTBN.Text;
            cccd = macccd.Text;
            ngheNghiep = nnBn.Text;
            sdt = SDTBN.Text;
            diaChi = diachibn.Text;
            date = DateBN.Value.ToString("yyyy/MM/dd");
            bhyt = bhytbn.Text;
            string sql = $"update dbo.BenhNhan set maBN = '{maBN}',hoTen = '{hoTen}',ngaySinh = '{date}',gioiTinh = '{gioiTinh}',cccd = '{cccd}',ngheNghiep = '{ngheNghiep}',bhyt = '{bhyt}',diaChi = '{diaChi}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            DialogResult = MessageBox.Show("Đã cập nhật thông tin bệnh nhân", "Thông Báo", MessageBoxButtons.OK);
            if (DialogResult == DialogResult.OK)
            {

                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            connect.Close();
        }
    }
}
