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
    public partial class FormThongKe : Form
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string dateFrom = dtpkFrom.Value.ToString("yyyy/MM/dd");
            string dateTo = dtpkTo.Value.ToString("yyyy/MM/dd");

            connect.Open();
            string query = $"select maHD as 'Mã HĐ', maBN as 'Mã BN', ngayLapHD as 'Ngày lập HĐ', tienKham as 'Tiền khám', tienDichVu as 'Tiền dịch vụ', tienThuoc as 'Tiền thuốc', tongTien as 'Tổng tiền', tienBaoHiem as 'Tiền bảo hiểm' from dbo.HoaDon where ngayLapHD <= '{dateTo}' and ngayLapHD >= '{dateFrom}'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, connect);
            adapter.SelectCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgvThongKe.DataSource = dt;
            connect.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
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

                            for (int col = 0; col < dtgvThongKe.Columns.Count; col++)
                            {
                                IXLCell header = worksheet.Cell(1, col + 1);
                                header.Value = dtgvThongKe.Columns[col].HeaderText;
                                header.Style.Font.SetBold();
                                worksheet.Column(col + 1).Width = 15; // Điều chỉnh độ rộng của cột (ví dụ: 15)

                            }

                            // Thêm dữ liệu từ DataGridView
                            for (int row = 0; row < dtgvThongKe.Rows.Count; row++)
                            {
                                for (int col = 0; col < dtgvThongKe.Columns.Count; col++)
                                {
                                    object cellValue = dtgvThongKe.Rows[row].Cells[col].Value;
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
                        MessageBox.Show("Xuất excel thành công", "Thông báo");
                        this.Close();
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
