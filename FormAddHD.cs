using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http.Headers;

namespace QLBV
{
    public partial class FormAddHD : Form
    {
        internal string maIdHD;
        internal string ngayLapHD = "";
        internal string tienKham = "0";
        internal string tienDichVu = "0";
        internal string tienBaoHiem = "0";
        internal string tienThuoc = "0";
        internal string maBN;
        internal string tenLoaiThuoc = "";
        internal string nameThuoc = "";
        internal int tempTienThuoc = 0;
        internal int tempTienKham = 0;
        internal int tempTienDichVu = 0;
        internal int tempTongTien = 0;
        internal int soLoaiThuoc = 0;
        internal int soLuongThuoc = 0;

        internal double phanTramBaoHiem = 1;

        internal DataTable tempDTThuoc = new DataTable();
        internal DataGridViewRow rowThuoc; // dùng để xóa thuốc





        public void setProperties(string idBN, string tenBN, string ngaySinh, string gioiTinh, string country, string ngayTaoHoaDon, string ngayLapHDddd)
        {
            lbIdBN.Text = idBN;
            lbName.Text = tenBN;
            lbCountry.Text = country;
            lbDate.Text = ngaySinh;
            lbSex.Text = gioiTinh;
            lbNgayTaoHD.Text = ngayTaoHoaDon;
            ngayLapHD = ngayLapHDddd;
        }


        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(cnn);

        public FormAddHD(string _maBN)
        {
            InitializeComponent();
            maBN = _maBN;
            maIdHD = createIdHD();
            lbIdHD.Text = maIdHD;
        }


        internal string createIdHD()
        {
            string kq;
            connect.Open();
            string sqlcmd = $"SELECT maHD FROM dbo.HoaDon";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sqlcmd, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            connect.Close();
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            char[] ketqua = { 'A', 'A', 'A', '0', '0', '0' };
            if (dt.Rows.Count != 0)
            {
                string tempKQ = new string(ketqua);
                string maTonTai = "";
                int temp;
                int p = 0;
                int i1, i2, i3, i4, i5, i6, dem;
                dem = 0;
                for (i1 = 65; i1 <= 90; i1++)
                {
                    for (i2 = 65; i2 <= 90; i2++)
                    {
                        for (i3 = 65; i3 <= 90; i3++)
                        {
                            for (i4 = 48; i4 <= 57; i4++)
                            {
                                for (i5 = 48; i5 <= 57; i5++)
                                {
                                    for (i6 = 48; i6 <= 57; i6++)
                                    {
                                        dem++;
                                        ketqua[0] = (char)i1;
                                        ketqua[1] = (char)i2;
                                        ketqua[2] = (char)i3;
                                        ketqua[3] = (char)i4;
                                        ketqua[4] = (char)i5;
                                        ketqua[5] = (char)i6;
                                        tempKQ = new string(ketqua);
                                        if (dem > dt.Rows.Count)
                                        {
                                            return tempKQ;
                                        }
                                        maTonTai = dt.Rows[p][0].ToString();
                                        if (tempKQ == maTonTai)
                                        {
                                            p++;
                                        }
                                        else
                                        {
                                            return tempKQ;
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            kq = new string(ketqua);
            return kq;
        }

        private void FormQLHD_Load(object sender, EventArgs e)
        {
            tempDTThuoc = newDT();
            addItemThuoc();
        }
        DataTable newDT()
        {
            DataTable dt = new DataTable();
            DataColumn col1 = new DataColumn("Tên Thuốc", typeof(string));
            col1.Unique = true;
            col1.ReadOnly = false;
            col1.AllowDBNull = true;
            dt.Columns.Add(col1);

            DataColumn col2 = new DataColumn("Đơn Giá", typeof(int));
            col2.Unique = false;
            col2.ReadOnly = false;
            col2.AllowDBNull = true;
            dt.Columns.Add(col2);

            DataColumn col3 = new DataColumn("Số lượng mua", typeof(int));
            col3.Unique = false;
            col3.ReadOnly = false;
            col3.AllowDBNull = true;
            dt.Columns.Add(col3);

            DataColumn col4 = new DataColumn("Thành Tiền", typeof(int));
            col4.Unique = false;
            col4.ReadOnly = false;
            col4.AllowDBNull = true;
            dt.Columns.Add(col4);

            DataColumn col5 = new DataColumn("Mã Thuốc", typeof(string));
            col5.Unique = false;
            col5.ReadOnly = false;
            col5.AllowDBNull = true;
            dt.Columns.Add(col5);

            DataColumn[] primery = new DataColumn[1];
            primery[0] = dt.Columns[0];
            dt.PrimaryKey = primery;

            return dt;
        }
        void addItemThuoc()
        {
            string sqlcmd = $"SELECT tenThuoc FROM dbo.Thuoc";

            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sqlcmd, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            connect.Close();

            DataTable dtTenThuoc = new DataTable();
            adapter.Fill(dtTenThuoc);

            for (int i = 0; i < dtTenThuoc.Rows.Count; i++)
            {
                comboBoxThuoc.Items.Add(dtTenThuoc.Rows[i][0].ToString());
            }
        }
        private void FormQLHD_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btFinal_Click(object sender, EventArgs e)
        {
            showTongTien();



            // thêm vào danh sách hóa đơn
            connect.Open();
            string sqlcmd = $"INSERT INTO dbo.HoaDon(maHD, tienKham, tienDichVu, tienThuoc, tongTien, ngayLapHD, maBN, tienBaoHiem) VALUES('{maIdHD}', {tienKham}, {tienDichVu}, {tienThuoc}, {tempTongTien}, '{ngayLapHD}', '{lbIdBN.Text}', '{tienBaoHiem}')";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sqlcmd, connect);
            adapter.InsertCommand.ExecuteNonQuery();

            string sqlcmd1;


            //thêm vào danh sách thuốc và update số thuốc trong kho
            for (int i = 0; i < tempDTThuoc.Rows.Count; i++)
            {
                sqlcmd = $"INSERT INTO dbo.HoaDonThuoc(maThuoc, maHD, soLuongMua, tien, tenThuoc) VALUES('{tempDTThuoc.Rows[i][4].ToString()}','{maIdHD}', {tempDTThuoc.Rows[i][2]}, {tempDTThuoc.Rows[i][3]}, '{tempDTThuoc.Rows[i][0]}')";
                adapter.InsertCommand = new SqlCommand(sqlcmd, connect);
                adapter.InsertCommand.ExecuteNonQuery();

                sqlcmd1 = $"UPDATE dbo.Thuoc SET soLuong = soLuong - {tempDTThuoc.Rows[i][2]} WHERE maThuoc = '{tempDTThuoc.Rows[i][4].ToString()}'";
                adapter.InsertCommand = new SqlCommand(sqlcmd1, connect);
                adapter.InsertCommand.ExecuteNonQuery();
            }

            connect.Close();
            Close();
            // for () ;
        }

        void showTongTien()
        {
            if (checkBoxBaoHiem.Checked == true)
            {
                phanTramBaoHiem = 0.65;
            }
            else
            {
                phanTramBaoHiem = 1;
            }
            if (tbTienKham.Text != "")
            {
                tienKham = tbTienKham.Text;
            }
            else
            {
                tienKham = "0";
            }
            if (tbTienDichVu.Text != "")
            {
                tienDichVu = tbTienDichVu.Text;
            }
            else
            {
                tienDichVu = "0";
            }

            tempTienThuoc = 0;
            for (int i = 0; i < tempDTThuoc.Rows.Count; i++)
            {
                tempTienThuoc = tempTienThuoc + (int)tempDTThuoc.Rows[i][3];
            }
            tienThuoc = tempTienThuoc.ToString();
            tempTienKham = int.Parse(tienKham);
            tempTienDichVu = int.Parse(tienDichVu);
            tempTongTien = (int)((tempTienKham + tempTienThuoc + tempTienDichVu) * phanTramBaoHiem);
            tienBaoHiem = ((int)((float)tempTongTien / phanTramBaoHiem * (1 - phanTramBaoHiem))).ToString();
            //MessageBox.Show($"TienBaoHiem : {tienBaoHiem}");
            lbTongTien.Text = tempTongTien.ToString() + " VNĐ";
        }


        void fillDSThuoc(DataTable dt)
        {
            dgvTienThuoc.DataSource = dt;
        }


        private void btTinhTien_Click(object sender, EventArgs e)
        {
            showTongTien();
        }

        private void btAddThuoc_Click(object sender, EventArgs e)
        {
            int i, vitri;
            bool check = true;


            tenLoaiThuoc = comboBoxThuoc.Text;
            soLuongThuoc = (int)nudSLT.Value;
            if (soLuongThuoc > 0)
            {
                for (i = 0; i < tempDTThuoc.Rows.Count; i++)
                {
                    if (tempDTThuoc.Rows[i][0].ToString() == tenLoaiThuoc)
                    {
                        check = false;
                        vitri = i;
                        break;
                    }
                }

                if (check == true)
                {
                    DataRow dtr = tempDTThuoc.NewRow();


                    string sqlcmd = $"SELECT donGia, soLuong, maThuoc FROM dbo.Thuoc WHERE tenThuoc = '{tenLoaiThuoc}'";

                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(sqlcmd, connect);
                    adapter.SelectCommand.ExecuteNonQuery();
                    connect.Close();

                    DataTable dtt = new DataTable();
                    adapter.Fill(dtt);

                    if (soLuongThuoc > (int)dtt.Rows[0][1])
                    {
                        MessageBox.Show($"Vượt quá số lượng thuốc trong kho !\n Số lượng thuốc trong kho còn lại: {dtt.Rows[0][1]}");
                        return;
                    }

                    dtr[0] = tenLoaiThuoc;
                    dtr[1] = dtt.Rows[0][0];
                    dtr[2] = soLuongThuoc;
                    dtr[3] = (int)dtt.Rows[0][0] * soLuongThuoc;
                    dtr[4] = dtt.Rows[0][2];

                    tempDTThuoc.Rows.Add(dtr);

                }
                else
                {
                    tempDTThuoc.Rows[i][2] = (int)tempDTThuoc.Rows[i][2] + soLuongThuoc;
                    tempDTThuoc.Rows[i][3] = (int)tempDTThuoc.Rows[i][1] * (int)tempDTThuoc.Rows[i][2];
                }
            }


            fillDSThuoc(tempDTThuoc);
        }

        private void btDelThuoc_Click(object sender, EventArgs e)
        {
            bool check = false;
            DataRow row = tempDTThuoc.Rows[0];  // giá trị ban đầu (sai)

            for (int i = 0; i < tempDTThuoc.Rows.Count; i++)
            {
                if (nameThuoc == tempDTThuoc.Rows[i][0].ToString())
                {
                    row = tempDTThuoc.Rows[i];
                    check = true;
                    break;
                }
            }
            if (check == true)
            {
                tempDTThuoc.Rows.Remove(row);
            }
        }

        private void dgvTienThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowThuoc = dgvTienThuoc.Rows[e.RowIndex];
                nameThuoc = rowThuoc.Cells[0].Value.ToString();
            }
        }

        private void comboBoxThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tt = comboBoxThuoc.SelectedItem.ToString();
            connect.Open();
            string sqlcmd = $"SELECT donGia FROM dbo.Thuoc WHERE tenThuoc = '{tt}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sqlcmd, connect);
            adapter.SelectCommand.ExecuteNonQuery();

            DataTable d = new DataTable();
            adapter.Fill(d);

            lbDonGia.Text = d.Rows[0][0].ToString() + "đ";
            connect.Close();
        }
    }
}
