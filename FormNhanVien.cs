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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;

namespace QLBV
{
    public partial class FormNhanVien : Form
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);

        internal string maNV, hoTen, gioiTinh, ngaySinh, chucVu, sdt, queQuan, diaChi;

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvNV.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dtgvNV.Columns[i].HeaderText;
            }
            for (int i = 0; i < dtgvNV.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvNV.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dtgvNV.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }


        public void showNV()
        {
            string query = "select maNV as 'Mã NV', hoTen as 'Họ tên', gioiTinh as 'Giới tính', ngaySinh as 'Ngày sinh', " +
                "chucVu as 'Chức vụ' , sdt as 'SĐT', queQuan as 'Quê quán', diaChi as 'Địa chỉ' from [dbo].[NhanVien]";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, connect);
            adapter.SelectCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dtgvNV.DataSource = dt;
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            connect.Open();

            showNV();

            connect.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connect.Open();

            string getCbbSearch = cbbSearch.Text;
            string getTxbSearch = txbSearch.Text;

            string query = $"select maNV as 'Mã NV', hoTen as 'Họ tên', gioiTinh as 'Giới tính', ngaySinh as 'Ngày sinh', " +
                $"chucVu as 'Chức vụ' , sdt as 'SĐT', queQuan as 'Quê quán', diaChi as 'Địa chỉ'" +
                $" from [dbo].[NhanVien] where {getCbbSearch} like '%{getTxbSearch}%'";

            if (getCbbSearch != "" && getTxbSearch != "")
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connect);
                adapter.SelectCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dtgvNV.DataSource = dt;

                connect.Close();
            }
            else
            {
                MessageBox.Show("Bạn hãy nhập dữ liệu để tìm kiếm!", "Thông báo");
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connect.Open();
            FormThemNhanVien tnv = new FormThemNhanVien();
            tnv.ShowDialog();
            showNV();

            connect.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    string query = $"delete dbo.NhanVien where maNV = '{maNV}'";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = new SqlCommand(query, connect);
                    adapter.DeleteCommand.ExecuteNonQuery();

                    string query1 = $"delete dbo.TaiKhoan where maNV = '{maNV}'";
                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    adapter1.DeleteCommand = new SqlCommand(query1, connect);
                    adapter1.DeleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công", "Thông báo");
                    showNV();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại! " + ex.Message, "Thông báo");
                }
            }

        }

        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvNV.Rows[e.RowIndex];

                maNV = selectedRow.Cells["Mã NV"].Value.ToString();
                hoTen = selectedRow.Cells["Họ tên"].Value.ToString();
                gioiTinh = selectedRow.Cells["Giới tính"].Value.ToString();
                ngaySinh = selectedRow.Cells["Ngày sinh"].Value.ToString();
                chucVu = selectedRow.Cells["Chức vụ"].Value.ToString();
                sdt = selectedRow.Cells["SĐT"].Value.ToString();
                queQuan = selectedRow.Cells["Quê quán"].Value.ToString();
                diaChi = selectedRow.Cells["Địa chỉ"].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            FormCapNhatNhanVien fcnnv = new FormCapNhatNhanVien();
            fcnnv.FillData(maNV, hoTen, gioiTinh, ngaySinh, chucVu, sdt, queQuan, diaChi);
            fcnnv.ShowDialog();

            showNV();
            connect.Close();

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            IXLWorksheet worksheet = workbook.Worksheets.Add("Sheet1");

                            for (int col = 0; col < dtgvNV.Columns.Count; col++)
                            {
                                IXLCell header = worksheet.Cell(1, col + 1);
                                header.Value = dtgvNV.Columns[col].HeaderText;
                                header.Style.Font.SetBold();
                                worksheet.Column(col + 1).Width = 15; // Điều chỉnh độ rộng của cột (ví dụ: 15)

                            }

                            // Thêm dữ liệu từ DataGridView
                            for (int row = 0; row < dtgvNV.Rows.Count; row++)
                            {
                                for (int col = 0; col < dtgvNV.Columns.Count; col++)
                                {
                                    object cellValue = dtgvNV.Rows[row].Cells[col].Value;
                                    if (cellValue != null)
                                    {
                                        worksheet.Cell(row + 2, col + 1).Value = cellValue.ToString();
                                    }
                                    else
                                    {
                                        worksheet.Cell(row + 2, col + 1).Value = string.Empty;
                                    }
                                }
                            }
                            string dateFormat = "dd/MM/yyyy";
                            worksheet.Column(4).CellsUsed().Style.DateFormat.Format = dateFormat;
                            workbook.SaveAs(sfd.FileName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
