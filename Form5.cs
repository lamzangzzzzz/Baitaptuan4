using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Baitaptuan4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string strConnectionString = "Data Source = LAPTOP-KC1106N3\\GIANG; Initial Catalog = QLBH; Integrated Security=True; User Id =sa; Password = 123456";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;

        void LoadSanPham(string maloai)
        {
            try
            {
                da = null;
                ds = new DataSet();
                da = new SqlDataAdapter("SELECT * FROM SanPham Where MaLoai='" + maloai + "'", conn);
                da.Fill(ds, "SanPham");
                dgSanPham.DataSource = ds.Tables["SanPham"];
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu, có lỗi rồi!");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                conn.Open();

                da = new SqlDataAdapter("SELECT * FROM LoaiSanPham", conn);
                ds = new DataSet();
                da.Fill(ds, "LoaiSanPham");
                cboLoaiSP.DataSource = ds.Tables["LoaiSanPham"];
                cboLoaiSP.DisplayMember = "TenLoai";
                cboLoaiSP.ValueMember = "MaLoai";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu, có lỗi rồi!");
            }
        }

        private void btLoc_Click(object sender, EventArgs e)
        {
            LoadSanPham(cboLoaiSP.SelectedValue.ToString());
        }
    }
}
