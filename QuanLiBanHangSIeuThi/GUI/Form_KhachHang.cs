using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Model;
using BUS;
using System.Data;

namespace GUI
{
    public partial class Form_KhachHang : Form
    {
        BUS_KhachHang dskh = null;
        public Form_KhachHang()
        {
            InitializeComponent();
        }

        public void OpenTextBox()
        {
            txtCode.Enabled = false;
            txtName.Enabled = true;
            txtPeopleId.Enabled = true;
            txtAddress.Enabled = true;
            txtTel.Enabled = true;
            dtpDateOfbird.Enabled = true;
            rdbFeMale.Enabled = true;
            rdbMale.Enabled = true;
        }

        public void CloseTextBox()
        {
            txtCode.Enabled = false;
            txtName.Enabled = false;
            txtPeopleId.Enabled = false;
            txtAddress.Enabled = false;
            txtTel.Enabled = false;
            dtpDateOfbird.Enabled = false;
            rdbFeMale.Enabled = false;
            rdbMale.Enabled = false;
        }

        public void setNull()
        {
            txtCode.Text = " Không điền vào ô này !";
            txtName.Text = "";
            txtPeopleId.Text = "";
            txtTel.Text = "";
            txtAddress.Text = "";
            txtName.Focus();
        }

        public List<string>  Themkh()
        {
            List<string> kh = new List<string>();
            string sex;
            if (rdbMale.Checked == true)
                sex = "Nam";
            else
                sex = "Nữ";
            int codeint = dataGridView1.Rows.Count + 1;
            string codestring = string.Format("{0:3N}", dataGridView1.Rows.Count.ToString());
            kh.Add(codestring);
            kh.Add(txtName.Text);
            kh.Add(Convert.ToDateTime(dtpDateOfbird.Text).ToString("MM/dd/yyyy"));
            kh.Add(sex);
            kh.Add(txtPeopleId.Text);
            kh.Add(txtAddress.Text);
            kh.Add(txtTel.Text);
            return kh;
        }

        private void Form_KhachHang_Load(object sender, EventArgs e)
        {
            dskh = new BUS_KhachHang();
            DataTable tbl = dskh.DSKhachHang();
            dataGridView1.DataSource = tbl;
            CloseTextBox();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            OpenTextBox();
            int index = dataGridView1.CurrentRow.Index;
            txtCode.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            dtpDateOfbird.Text = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
            if (dataGridView1.Rows[index].Cells[3].Value.ToString() == "Nam")
                rdbMale.Checked = true;
            else
                rdbFeMale.Checked = true;
            txtPeopleId.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txtTel.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            setNull();
            OpenTextBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dskh = new BUS_KhachHang();
            if(dskh.ThemkH(Themkh()))
            {
                MessageBox.Show("Đã thêm mới khách hàng !", "Thông báo", MessageBoxButtons.OK);
                DataTable tbl = dskh.DSKhachHang();
                dataGridView1.DataSource = tbl;
            }
            else
                MessageBox.Show("Không thêm mới được khách hàng ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // sửa 
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn sửa khách hàng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Enabled = false;
                dskh = new BUS_KhachHang();
                string codeId = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                if(dskh.SuaKh(Themkh(),codeId))
                {
                    MessageBox.Show("Đã sửa khách hàng !", "Thông báo", MessageBoxButtons.OK);
                    DataTable tbl = dskh.DSKhachHang();
                    dataGridView1.DataSource = tbl;
                    dataGridView1.Enabled = true;
                }
                else
                    MessageBox.Show("Không sửa được khách hàng ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa khách hàng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dskh = new BUS_KhachHang();
                string codeId = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                if (dskh.XoaKh(codeId))
                {
                    MessageBox.Show("Đã xoá khách hàng !", "Thông báo", MessageBoxButtons.OK);
                    DataTable tbl = dskh.DSKhachHang();
                    dataGridView1.DataSource = tbl;
                }
                else
                    MessageBox.Show("Không xóa được nhân viên ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
