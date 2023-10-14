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
    public partial class FormThemGiuongBenh : Form
    {

        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBV;Integrated Security=True";
        SqlConnection connect = new SqlConnection(cnn);

        public FormThemGiuongBenh()
        {
            InitializeComponent();
        }

        internal string maGiuong, tinhTrang;

        private void FormThemGiuongBenh_Load(object sender, EventArgs e)
        {

        }

        private void addGB_Click(object sender, EventArgs e)
        {
            connect.Open();

            maGiuong = ValueMBG.Text;
            tinhTrang = "0";

            string sql = $"insert into dbo.GiuongBenh (maGiuong, tinhTrang) values ('{maGiuong}' , '{tinhTrang}')";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, connect);
            adapter.InsertCommand.ExecuteNonQuery();

            connect.Close();
            this.Close();
            MessageBox.Show("Thêm giường bệnh thành công !", "Thông báo");
        }

        private void huytgb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
