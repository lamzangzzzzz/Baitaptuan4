using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaptuan4
{
    public partial class FormTongHop : Form
    {
        public FormTongHop()
        {
            InitializeComponent();
        }

        private void btnQuanLySP_Click(object sender, EventArgs e)
        {
            QuanLySP f = new QuanLySP();
            f.Show();
        }

        private void btnPhanTrang_Click(object sender, EventArgs e)
        {
            Phantrang f = new Phantrang();
            f.Show();
        }

        private void LocSanPham_Click(object sender, EventArgs e)
        {
            LocSP f = new LocSP();
            f.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemSP f = new TimKiemSP();
            f.Show();
        }

        private void btnXemDMSP_Click(object sender, EventArgs e)
        {
            XemDMSP f = new XemDMSP();
            f.Show();
        }
    }
}
