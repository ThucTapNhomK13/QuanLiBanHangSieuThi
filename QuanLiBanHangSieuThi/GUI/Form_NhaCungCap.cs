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
    public partial class Form_NhaCungCap : Form
    {
        BUS_NhaCungCap ncc;
        public Form_NhaCungCap()
        {
            InitializeComponent();
        }
        public void CloseTextBox()
        {
            txtCode.Enabled = false;
            txtCount.Enabled = false;
            txtCodeBIll.Enabled = false;
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            
        }
        public void OpenTextBox()
        {
            txtCode.Enabled = true;
            txtCount.Enabled = true;
            txtCodeBIll.Enabled = true;
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            
        }
        public List<string> them()
        {
            List<string> ncc = new List<string>();
            ncc.Add(txtCode.Text);
            ncc.Add(txtName.Text);
            ncc.Add(txtCodeBIll.Text);
            ncc.Add(txtPrice.Text);
            ncc.Add(txtCount.Text);
            return ncc;
        }
        // them
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thêm mới nhà cung cấp ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {           
                if (ncc.ThemNcc(them()))
                {
                    MessageBox.Show("Đã thêm mới nhà cung cấp !", "Thông báo", MessageBoxButtons.OK);
                    DataTable tbl = ncc.DSNcc();
                    dataGridView1.DataSource = tbl;
                }
                else
                    MessageBox.Show("Không thêm mới được nhà cung cấp ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_NhaCungCap_Load(object sender, EventArgs e)
        {
            ncc = new BUS_NhaCungCap();
            DataTable tbl = ncc.DSNcc();
            dataGridView1.DataSource = tbl;
        }
        // sua
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn sửa thông tin nhà cung cấp này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Enabled = false;
                ncc = new BUS_NhaCungCap();
                string codeId = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                if (ncc.SuaNcc(them(), codeId))
                {
                    MessageBox.Show("Đã sửa nhà cung cấp !", "Thông báo", MessageBoxButtons.OK);
                    DataTable tbl = ncc.DSNcc();
                    dataGridView1.DataSource = tbl;
                    dataGridView1.Enabled = true;
                }
                else
                    MessageBox.Show("Không sửa được nhà cung cấp ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // xoa
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhà cung cấp này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string codeId = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                ncc = new BUS_NhaCungCap();
                if (ncc.XoaNcc(codeId))
                {
                    MessageBox.Show("Đã xoá nhà cung cấp !", "Thông báo", MessageBoxButtons.OK);
                    DataTable tbl = ncc.DSNcc();
                    dataGridView1.DataSource = tbl;
                }
                else
                    MessageBox.Show("Không xóa được nhà cung cấp ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

    }
}
