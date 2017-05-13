using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login lg = new Form_Login();
            lg.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_NhanVien nv = new Form_NhanVien();
            nv.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_KhachHang kh = new Form_KhachHang();
            kh.ShowDialog();
            this.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_NhaCungCap ncc = new Form_NhaCungCap();
            ncc.ShowDialog();
            this.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MatHang mh = new Form_MatHang();
            mh.ShowDialog();
            this.Show();
        }

        private void tìmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TImKIem_NhanVien nv = new Form_TImKIem_NhanVien();
            nv.Show();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_TImKiem_KhachHang kh = new Form_TImKiem_KhachHang();
            kh.ShowDialog();
            this.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            this.Hide();
            help.Show();
        }
    }
}
