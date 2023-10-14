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
    public partial class FormThemBenhNhan : Form
    {
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(cnn);
        public FormThemBenhNhan()
        {
            InitializeComponent();
        }
        internal string maBN, hoTen, gioiTinh, cccd, ngheNghiep, sdt, bhyt, diaChi;
        internal string date;
        private void AddBN_Click(object sender, EventArgs e)
        {
            connect.Open();

            maBN = ValueMBN.Text;
            hoTen = ValueName.Text;
            gioiTinh = ValueGT.Text;
            cccd = ValueID.Text;
            ngheNghiep = ValueNN.Text;
            sdt = ValueSDT.Text;
            bhyt = ValueBHYT.Text;
            diaChi = ValueDC.Text;
            date = ValueDate.Value.ToString("yyyy/MM/dd");

            string sql = $"insert into dbo.BenhNhan(maBN,hoTen,gioiTinh,ngaySinh,cccd,ngheNghiep,sdt,bhyt,diaChi) values ('{maBN}','{hoTen}','{gioiTinh}','{date}','{cccd}','{ngheNghiep}','{sdt}','{bhyt}','{diaChi}')";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, connect);
            adapter.InsertCommand.ExecuteNonQuery();

            connect.Close();
            this.Close();


        }


        private void FormThemBenhNhan_Load(object sender, EventArgs e)
        {


        }

        private void exitFormAddBN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
