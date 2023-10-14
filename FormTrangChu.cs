using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBV
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMK ttcn = new FormDoiMK();
            ttcn.ShowDialog();

        }

        private void btnQLBN_Click(object sender, EventArgs e)
        {
            FormQuanLyBenhNhan fqlbn = new FormQuanLyBenhNhan();
            fqlbn.ShowDialog();
        }

        private void btnQLThuoc_Click(object sender, EventArgs e)
        {
            FormQuanLyThuoc fqlt = new FormQuanLyThuoc();
            fqlt.ShowDialog();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            int type = int.Parse(FormDangNhap.loaiTaiKhoan);
            if (type == 1)
            {
                FormNhanVien fnv = new FormNhanVien();
                fnv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản của bạn chưa được cấp quyền cho chức năng này!", "Thông báo");
            }

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormQuanLyGiuongBenh formQuanLyGiuongBenh = new FormQuanLyGiuongBenh();
            formQuanLyGiuongBenh.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe ftk = new FormThongKe();
            ftk.ShowDialog();
        }
    }
}
