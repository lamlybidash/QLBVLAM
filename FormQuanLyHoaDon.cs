using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBV
{
    public partial class FormQuanLyHoaDon : Form
    {
        internal string maBN;
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(cnn);
        public FormQuanLyHoaDon(string _maBN)
        {
            InitializeComponent();
            this.maBN = _maBN;
        }

        public void BindingDshdToCbb()
        {
            connect.Open();
            string query = $"select MaHD from dbo.HoaDon where maBN = '{maBN}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, connect);
            adapter.SelectCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maHD = dt.Rows[i][0].ToString();
                cbbDSHD.Items.Add(maHD);
            }

            connect.Close();
        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            //showMaHD();
            showI4BN();
            BindingDshdToCbb();
        }


        public void xoaHDtheoBN(string maBN1)
        {
            connect.Open();
            string sqlcmd = $"SELECT maHD FROM dbo.HoaDon WHERE maBN = '{maBN1}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sqlcmd, connect);
            adapter.SelectCommand.ExecuteNonQuery();

            DataTable dtDel = new DataTable();

            adapter.Fill(dtDel);
            string sqlcmd2;
            for (int i = 0; i < dtDel.Rows.Count; i++)
            {
                sqlcmd2 = $"DELETE dbo.HoaDonThuoc WHERE maHD = '{dtDel.Rows[i][0]}'";
                adapter2.DeleteCommand = new SqlCommand(sqlcmd2, connect);
                adapter2.DeleteCommand.ExecuteNonQuery();
            }

            sqlcmd = $"DELETE dbo.HoaDon WHERE maBN = '{maBN1}'";
            adapter.SelectCommand = new SqlCommand(sqlcmd, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            connect.Close();
        }

        /*     public void showMaHD(string ma)
             {
                 connect.Open();
                 maBN = ma;
                 string sqlcmd = $"SELECT maHD FROM dbo.HoaDon WHERE maBN = '{maBN}'";
                 SqlDataAdapter adapter = new SqlDataAdapter();
                 adapter.SelectCommand = new SqlCommand(sqlcmd, connect);
                 adapter.SelectCommand.ExecuteNonQuery();

                 DataTable dt = new DataTable();
                 adapter.Fill(dt);

                 dgvDSHD.DataSource = dt;
                 connect.Close();
             }
     */
        /*        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
                {

                    if (e.RowIndex >= 0)
                    {
                        DataGridViewCell cell = dgvDSHD.Rows[e.RowIndex].Cells[0];
                        string sqlcmd = $"SELECT * FROM dbo.HoaDon WHERE maHD='{cell.Value}'";

                        connect.Open();
                        SqlDataAdapter adapterhd = new SqlDataAdapter();
                        adapterhd.SelectCommand = new SqlCommand(sqlcmd, connect);
                        adapterhd.SelectCommand.ExecuteNonQuery();
                        connect.Close();

                        DataTable dthd = new DataTable();
                        adapterhd.Fill(dthd);

                        if (dthd.Rows.Count > 0)
                        {
                            lbIdHD.Text = cell.Value.ToString();
                            lbTienKham.Text = dthd.Rows[0]["tienKham"].ToString();
                            lbTienDichVu.Text = dthd.Rows[0]["tienDichVu"].ToString();
                            DateTime dt = DateTime.Now;
                            dt = (DateTime)dthd.Rows[0]["ngayLapHD"];
                            lbDateHD.Text = dt.ToString("dd/MM/yyyy");
                            lbIdBN.Text = dthd.Rows[0]["maBN"].ToString();
                            lbTienBaoHiem.Text = dthd.Rows[0]["tienBaoHiem"].ToString();
                            lbTongTien.Text = dthd.Rows[0]["tongTien"].ToString();
                        }

                        connect.Open();
                        sqlcmd = $"SELECT * FROM dbo.BenhNhan WHERE maBN='{lbIdBN.Text}'";
                        SqlDataAdapter adapterbn = new SqlDataAdapter();
                        adapterbn.SelectCommand = new SqlCommand(sqlcmd, connect);
                        adapterbn.SelectCommand.ExecuteNonQuery();
                        connect.Close();
                        DataTable dtbn = new DataTable();
                        adapterbn.Fill(dtbn);


                        if (dtbn.Rows.Count > 0)
                        {
                            lbName.Text = dtbn.Rows[0]["hoTen"].ToString();
                            lbSex.Text = dtbn.Rows[0]["gioiTinh"].ToString();
                            DateTime dt2 = DateTime.Now;
                            dt2 = (DateTime)dtbn.Rows[0]["ngaySinh"];
                            lbDate.Text = dt2.ToString("dd/MM/yyyy");
                            lbCountry.Text = dtbn.Rows[0]["diaChi"].ToString();
                        }
                        connect.Open();
                        sqlcmd = $"SELECT tenThuoc,soLuongMua,tien FROM dbo.HoaDonThuoc WHERE maHD='{cell.Value.ToString()}'";
                        SqlDataAdapter adapterhdt = new SqlDataAdapter();
                        adapterhdt.SelectCommand = new SqlCommand(sqlcmd, connect);
                        adapterhdt.SelectCommand.ExecuteNonQuery();
                        connect.Close();
                        DataTable dthdt = new DataTable();
                        adapterhdt.Fill(dthdt);

                        dgvDSThuoc.DataSource = dthdt;

                    }

                }*/

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddHD formAddHD = new FormAddHD(maBN);
            DateTime dt = DateTime.Now;
            string date = dt.ToString("dd/MM/yyyy");
            string dateddd = dt.ToString("yyyy/MM/dd");
            formAddHD.setProperties(maBN, lbName.Text, lbDate.Text, lbSex.Text, lbCountry.Text, date, dateddd);
            formAddHD.ShowDialog();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btDel_Click(object sender, EventArgs e)
        {
            connect.Open();
            string maHD = lbIdHD.Text;
            string sqlcmd1 = $"DELETE dbo.HoaDon WHERE maHD = '{maHD}'";
            string sqlcmd2 = $"DELETE dbo.HoaDonThuoc WHERE maHD = '{maHD}'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = new SqlCommand(sqlcmd1, connect);
            adapter.DeleteCommand.ExecuteNonQuery();
            adapter.DeleteCommand = new SqlCommand(sqlcmd2, connect);
            adapter.DeleteCommand.ExecuteNonQuery();
            connect.Close();

        }

        void showI4BN()
        {
            connect.Open();
            string sqlcmd = $"SELECT hoTen, ngaySinh, diaChi, gioiTinh FROM dbo.BenhNhan WHERE maBN ='{maBN}'";
            SqlDataAdapter adt = new SqlDataAdapter();
            adt.SelectCommand = new SqlCommand(sqlcmd, connect);
            adt.SelectCommand.ExecuteNonQuery();

            DataTable dti4 = new DataTable();
            adt.Fill(dti4);

            lbIdBN.Text = maBN;
            lbName.Text = dti4.Rows[0][0].ToString();
            DateTime timee = DateTime.Now;
            timee = (DateTime)dti4.Rows[0][1];
            lbDate.Text = timee.ToString("dd/MM/yyyy");
            lbCountry.Text = dti4.Rows[0][2].ToString();
            lbSex.Text = dti4.Rows[0][3].ToString();
            connect.Close();
        }

        private void cbbDSHD_SelectedIndexChanged(object sender, EventArgs e)
        {

            string maHDselect = cbbDSHD.SelectedItem.ToString();

            string sqlcmd = $" SELECT tienKham, tienDichVu, tongTien, ngayLapHD, tienBaoHiem FROM dbo.HoaDon WHERE maHD = '{maHDselect}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sqlcmd, connect);

            try
            {
                connect.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                connect.Close();
            }
            catch {
                connect.Close();
                MessageBox.Show("Xuat hien loi");
            }


            DataTable dtHD = new DataTable();
            adapter.Fill(dtHD);

            lbIdHD.Text = maHDselect;
            DateTime timee = DateTime.Now;
            timee = (DateTime)dtHD.Rows[0][3];
            lbDateHD.Text = timee.ToString("dd/MM/yyyy");
            lbTienBaoHiem.Text = "-" + dtHD.Rows[0][4].ToString() + "đ";
            lbTienDichVu.Text = dtHD.Rows[0][1].ToString() + " đ";
            lbTienKham.Text = dtHD.Rows[0][0].ToString() + " đ";
            lbTongTien.Text = dtHD.Rows[0][2].ToString() + " đ";

            sqlcmd = $"SELECT tenThuoc,soLuongMua,tien FROM dbo.HoaDonThuoc WHERE maHD='{maHDselect}'";
            try
            {
                connect.Open();
                SqlDataAdapter adapterhdt = new SqlDataAdapter();
                adapterhdt.SelectCommand = new SqlCommand(sqlcmd, connect);
                adapterhdt.SelectCommand.ExecuteNonQuery();
                connect.Close();
                DataTable dthdt = new DataTable();
                adapterhdt.Fill(dthdt);
                dgvDSThuoc.DataSource = dthdt;

                MessageBox.Show("Thanh cong xuat hd thuoc");

            }
            catch 
            {
                connect.Close() ;
                MessageBox.Show("Xuat hien Loi");
            }

            connect.Close();
        }
    }
}
