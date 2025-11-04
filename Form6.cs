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
    public partial class LocSP : Form
    {
        public LocSP()
        {
            InitializeComponent();
        }
        string strConnectionString = "Data Source = LAPTOP-KC1106N3\\GIANG; Initial Catalog = QLBH; Integrated Security=True; User Id =sa; Password = 123456";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                conn.Open();

                da = new SqlDataAdapter("SELECT * FROM LoaiSanPham", conn);
                ds = new DataSet();
                da.Fill(ds, "LoaiSanPham");
                trvLoaiSanPham.Nodes.Clear();

                TreeNode node;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    node = new TreeNode();
                    node.Text = dr["TenLoai"].ToString(); // hiển thị
                    node.Tag = dr["MaLoai"].ToString();  // giá trị mã loại
                    trvLoaiSanPham.Nodes.Add(node);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu, có lỗi rồi!");
            }
        }
        void LoadSanPham(string maloai)
        {
            try
            {

                // Vận chuyển dữ liệu vào DataGridView 
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

        private void trvLoaiSanPham_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string maloai = trvLoaiSanPham.SelectedNode.Tag.ToString();
            LoadSanPham(maloai);
        }
    }
}
