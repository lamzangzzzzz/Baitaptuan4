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
    public partial class Phantrang : Form
    {
        public Phantrang()
        {
            InitializeComponent();
        }
        string strConnectionString = "Data Source = LAPTOP-KC1106N3\\GIANG; Initial Catalog = QLBH; Integrated Security=True; User Id =sa; Password = 123456";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        DataTable dtSP;
        int vitri = -1;

        void LoadLoaiSanPham()
        {
            // Vận chuyển dữ liệu vào ComboBox
            da = new SqlDataAdapter("SELECT * FROM LoaiSanPham", conn);
            ds = new DataSet();
            da.Fill(ds, "LoaiSanPham");
            cboLoaiSP.DataSource = ds.Tables["LoaiSanPham"];
            cboLoaiSP.DisplayMember = "TenLoai";
            cboLoaiSP.ValueMember = "MaLoai";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //Khởi tạo kết nối
            conn = new SqlConnection(strConnectionString);
            //Mở kết nối
            conn.Open();
            // Đưa dữ liệu vào Bảng sản phẩm dtSP
            da = new SqlDataAdapter("SELECT * FROM SanPham", conn);
            ds = new DataSet();
            da.Fill(ds, "SanPham");
            dtSP = ds.Tables["SanPham"];
            btFirst.PerformClick(); //thực hiện chọn nút First đầu tiên
            LoadLoaiSanPham();

        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            if (dtSP.Rows.Count == 0) return;
            vitri = 0;
            txtMaSP.Text = dtSP.Rows[vitri]["MaSP"].ToString();
            txtTenSP.Text = dtSP.Rows[vitri]["TenSP"].ToString();
            txtDVT.Text = dtSP.Rows[vitri]["DVTinh"].ToString();
            txtDonGia.Text = dtSP.Rows[vitri]["DonGia"].ToString();
            cboLoaiSP.SelectedValue = dtSP.Rows[vitri]["MaLoai"].ToString();
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            if (dtSP.Rows.Count == 0) return;
            vitri--;
            if (vitri < 0) vitri = 0;
            txtMaSP.Text = dtSP.Rows[vitri]["MaSP"].ToString();
            txtTenSP.Text = dtSP.Rows[vitri]["TenSP"].ToString();
            txtDVT.Text = dtSP.Rows[vitri]["DVTinh"].ToString();
            txtDonGia.Text = dtSP.Rows[vitri]["DonGia"].ToString();
            cboLoaiSP.SelectedValue = dtSP.Rows[vitri]["MaLoai"].ToString();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (dtSP.Rows.Count == 0) return;
            vitri++;
            if (vitri > dtSP.Rows.Count - 1) vitri = dtSP.Rows.Count - 1;
            txtMaSP.Text = dtSP.Rows[vitri]["MaSP"].ToString();
            txtTenSP.Text = dtSP.Rows[vitri]["TenSP"].ToString();
            txtDVT.Text = dtSP.Rows[vitri]["DVTinh"].ToString();
            txtDonGia.Text = dtSP.Rows[vitri]["DonGia"].ToString();
            cboLoaiSP.SelectedValue = dtSP.Rows[vitri]["MaLoai"].ToString();
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            if (dtSP.Rows.Count == 0) return;
            vitri = dtSP.Rows.Count - 1;
            txtMaSP.Text = dtSP.Rows[vitri]["MaSP"].ToString();
            txtTenSP.Text = dtSP.Rows[vitri]["TenSP"].ToString();
            txtDVT.Text = dtSP.Rows[vitri]["DVTinh"].ToString();
            txtDonGia.Text = dtSP.Rows[vitri]["DonGia"].ToString();
            cboLoaiSP.SelectedValue = dtSP.Rows[vitri]["MaLoai"].ToString();
        }
    }
}
