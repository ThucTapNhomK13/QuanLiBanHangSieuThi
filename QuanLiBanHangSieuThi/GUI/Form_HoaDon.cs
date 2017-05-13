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

namespace GUI
{
    public partial class Form_HoaDon : Form
    {
        public Form_HoaDon()
        {
            InitializeComponent();
        }

        public void SetDefault()
        {
            txtCodeBill.Text = "";
            txtCodeMember.Text = "";
            txtCodeStaff.Text = "";
            txtSafe.Text = "";
            txtSum.Text = "";
        }

        public void CloseTextBox()
        {
            txtCodeBill.Enabled = false;
            txtCodeMember.Enabled = false;
            txtCodeStaff.Enabled = false;
            txtSafe.Enabled = false;
            txtSum.Enabled = false;
            dtpDateOfPrint.Enabled = false;
        }

        public void OpenTextBox()
        {
            txtCodeBill.Enabled = true;
            txtCodeMember.Enabled = true;
            txtCodeStaff.Enabled = true;
            txtSafe.Enabled = true;
            txtSum.Enabled = true;
            dtpDateOfPrint.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUS_HoaDon ihd = new BUS_HoaDon();
            List<string> hd = new List<string>();
            ;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                List<string> cthd = new List<string>();
                cthd.Add(txtCodeBill.Text);
                cthd.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                cthd.Add(dataGridView1.Rows[i].Cells[3].Value.ToString());
                cthd.Add(dataGridView1.Rows[i].Cells[2].Value.ToString());               
                ihd.ChiTietHoaDon(cthd);
               
            }
            hd.Add(txtCodeBill.Text);
            hd.Add(txtCodeMember.Text);
            hd.Add(txtCodeStaff.Text);
            hd.Add(Convert.ToDateTime(dtpDateOfPrint.Text).ToString("MM/dd/yyyy"));
            hd.Add(txtSafe.Text);
            hd.Add(txtSum.Text);
            if (ihd.ThemHd(hd))
                MessageBox.Show("Đã thêm mới hoá đơn !", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Không thêm mới được hoá đơn ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public DataTable createTable()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Stt");
            tb.Columns.Add("Tên mặt hàng");
            tb.Columns.Add("Giá");
            tb.Columns.Add("Số lượng");           
            return tb;
        }
        int i = 1;
        int sum = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(i, cmbList.SelectedItem.ToString(), 
                dataGridView2.Rows[cmbList.SelectedIndex].Cells["gia"].Value.ToString(), txtCount.Text.ToString());
            dataGridView2.RefreshEdit();
            i++;           
            sum += int.Parse(txtCount.Text.ToString()) * Convert.ToInt32(dataGridView2.Rows[cmbList.SelectedIndex].Cells[4].Value.ToString());
            txtSum.Text = sum.ToString();
            txtCount.Text = "";
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            BUS_HoaDon hd = new BUS_HoaDon();
            DataTable tbl = hd.DSMatHang();
            dataGridView2.DataSource = tbl;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                cmbList.Items.Add(dataGridView2.Rows[i].Cells["tenmathang"].Value.ToString());
            }
            CloseTextBox();
        }
    }
}
