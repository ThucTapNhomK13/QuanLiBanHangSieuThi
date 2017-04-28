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
using DTO_Model;
using System.Data;

namespace GUI
{
    public partial class Form_NhanVien : Form
    {
        BUS_NhanVien bsnv = null;
        public Form_NhanVien()
        {
            InitializeComponent();
        }
        // Thêm
        private void btnPrint_Click(object sender, EventArgs e)
        {
            OpenTextBox();
            SetDefault();
        }
        public List<string> them()
        {
            List<string> nv = new List<string>();
            string sex;
            if (rdbMale.Checked == true)
                sex = "Nam";
            else
                sex = "Nữ";
            int codeint = dataGridView.Rows.Count + 1;
            string codestring = string.Format("{0:3N}", dataGridView.Rows.Count.ToString());          
            nv.Add(codestring);         
            nv.Add(txtName.Text);
            nv.Add(txtCountry.Text);
            nv.Add(txtAddress.Text);
            nv.Add(sex);
            nv.Add(txtTribel.Text);
            nv.Add(txtPeopleId.Text);
            nv.Add(Convert.ToDateTime(txtDateOfBird.Text).ToString("MM/dd/yyyy"));
            nv.Add(txtMeasure.Text);
            nv.Add(txtPosition.Text);
            nv.Add(txtLocation.Text);
            nv.Add(txtTel.Text);
            return nv;
        }

        public void SetDefault()
        {
            txtAddress.Text = "";
            txtCode.Text = " Không điền ô này ! ";
            txtCountry.Text = "";
            txtDateOfBird.Text = "";
            txtLocation.Text = "";
            txtName.Text = "";
            txtPeopleId.Text = "";
            txtPosition.Text = "";
            txtTribel.Text = "";
            txtTel.Text = "";
            txtMeasure.Text = " ";
            txtName.Focus();
        }

        public void CloseTextBox()
        {
            txtAddress.Enabled = false;
            txtCode.Enabled = false;
            txtCountry.Enabled = false;
            txtDateOfBird.Enabled = false;
            txtLocation.Enabled = false;
            txtName.Enabled = false; 
            txtPeopleId.Enabled = false; ;
            txtPosition.Enabled = false; 
            txtTribel.Enabled = false; 
            txtTel.Enabled = false;
            txtMeasure.Enabled = false;
        }

        public void OpenTextBox()
        {
            txtAddress.Enabled = true;
            txtCode.Enabled = false;
            txtCountry.Enabled = true;
            txtDateOfBird.Enabled = true;
            txtLocation.Enabled = true;
            txtName.Enabled = true;
            txtPeopleId.Enabled = true; ;
            txtPosition.Enabled = true;
            txtTribel.Enabled = true;
            txtTel.Enabled = true;
            txtMeasure.Enabled = true;
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {           
            bsnv = new BUS_NhanVien();
            DataTable tbl = bsnv.DSNhanVien();
            dataGridView.DataSource = tbl;
            CloseTextBox();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentRow.Index;      
            txtCode.Text = dataGridView.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dataGridView.Rows[index].Cells[1].Value.ToString();
            txtCountry.Text = dataGridView.Rows[index].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView.Rows[index].Cells[3].Value.ToString();
            if (dataGridView.Rows[index].Cells[4].Value.ToString() == "Nam")
                rdbMale.Checked = true;
            else
                rdbFeMale.Checked = true;
            txtTribel.Text = dataGridView.Rows[index].Cells[5].Value.ToString();
            txtPeopleId.Text = dataGridView.Rows[index].Cells[6].Value.ToString();
            txtDateOfBird.Text = dataGridView.Rows[index].Cells[7].Value.ToString();
            txtMeasure.Text = dataGridView.Rows[index].Cells[8].Value.ToString();
            txtPosition.Text = dataGridView.Rows[index].Cells[9].Value.ToString();
            txtLocation.Text = dataGridView.Rows[index].Cells[10].Value.ToString();
            txtTel.Text = dataGridView.Rows[index].Cells[11].Value.ToString();
            OpenTextBox();           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {          
            bsnv = new BUS_NhanVien();
            if (bsnv.ThemNv(them()))
            {
                MessageBox.Show("Đã thêm mới nhân viên !", "Thông báo", MessageBoxButtons.OK);
                DataTable tbl = bsnv.DSNhanVien();
                dataGridView.DataSource = tbl;
            }              
            else
                MessageBox.Show("Không thêm mới được nhân viên ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // Xoa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string codeId = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            bsnv = new BUS_NhanVien();
            if (bsnv.XoaNv(codeId))
            {
                MessageBox.Show("Đã xoá nhân viên !", "Thông báo", MessageBoxButtons.OK);
                DataTable tbl = bsnv.DSNhanVien();
                dataGridView.DataSource = tbl;
            }                
            else
                MessageBox.Show("Không xóa được nhân viên ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sua
        private void btnModify_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn sửa thông tin nhân viên này không ?","Xác nhận", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            { 
            dataGridView.Enabled = false;
            bsnv = new BUS_NhanVien();
            string codeId = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            if (bsnv.SuaNv(them(),codeId))
            {
                MessageBox.Show("Đã sửa nhân viên !", "Thông báo", MessageBoxButtons.OK);
                DataTable tbl = bsnv.DSNhanVien();
                dataGridView.DataSource = tbl;
                dataGridView.Enabled = true;
            }
            else
                MessageBox.Show("Không sửa được nhân viên ! Vui lòng thử lại !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
