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

namespace Baitaptuan4
{
    public partial class XemDMSP : Form
    {
        public XemDMSP()
        {
            InitializeComponent();
        }
        string strConnectionString = "Data Source = LAPTOP-KC1106N3\\GIANG; Initial Catalog = QLBH; Integrated Security=True; User Id =sa; Password = 123456";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;

        private void Form4_Load(object sender, EventArgs e)
        {
            TimKiem(txtKeyWord.Text);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem(txtKeyWord.Text);
        }
        void TimKiem(string keyword)
        {
            try
            {
                //Khởi tạo kết nối
                conn = new SqlConnection(strConnectionString);
                //Mở kết nối
                conn.Open();

                //Khai báo câu truy vấn
                string sql = "";
                if (keyword != "")
                {
                    sql = "SELECT * FROM SanPham Where TenSP like N'%" + keyword + "%'";
                }
                else
                {
                    sql = "SELECT * FROM SanPham";
                }

                // Vận chuyển dữ liệu vào DataGridView dgSanPham
                da = new SqlDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds, "ABC");
                dgSanPham.DataSource = ds.Tables["ABC"];
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu, có lỗi rồi!");
            }
        }

    }
}
