using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data;

namespace GUI
{
    public partial class Form_MatHang : Form
    {
        BUS_MatHang hd;
        public Form_MatHang()
        {
            InitializeComponent();
        }
        public void CloseTextBox()
        {
            txtCode.Enabled = false;
            txtCount.Enabled = false;
            txtInfomation.Enabled = false;
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtProvided.Enabled = false;           
        }
        public void OpenTextBox()
        {
            txtCode.Enabled = true;
            txtCount.Enabled = true;
            txtInfomation.Enabled = true;
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtProvided.Enabled = true;
        }
        private void Form_MatHang_Load(object sender, EventArgs e)
        {
            hd = new BUS_MatHang();
            DataTable tbl = hd.DSMatHang();
            dataGridView1.DataSource = tbl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tạo mới mặt hàng ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<string> mh = new List<string>();
                mh.Add(txtCode.Text);
                mh.Add(txtName.Text);
                mh.Add(txtCount.Text);
                mh.Add(txtInfomation.Text);
                mh.Add(txtPrice.Text);
                mh.Add(txtProvided.Text);
                if (hd.ThemMh(mh))
                {
                    MessageBox.Show("Đã thêm mới mặt hàng !", "Thông báo", MessageBoxButtons.OK);
                    DataTable tbl = hd.DSMatHang();
                    dataGridView1.DataSource = tbl;
                }
                else
                    MessageBox.Show("Không thêm mới được mặt hàng ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
