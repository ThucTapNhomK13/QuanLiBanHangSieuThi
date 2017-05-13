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
    public partial class Form_TImKIem_NhanVien : Form
    {

        BUS_NhanVien bsnv = null;

        public Form_TImKIem_NhanVien()
        {
            InitializeComponent();
        }
        public void CloseTextBox()
        {
            txtAddress.Enabled = false;
            txtCode.Enabled = false;
            txtCountry.Enabled = false;
            dtpDateOfBird.Enabled = false;
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
            txtCode.Enabled = true;
            txtCountry.Enabled = true;
            dtpDateOfBird.Enabled = true;
            txtLocation.Enabled = true;
            txtName.Enabled = true;
            txtPeopleId.Enabled = true; ;
            txtPosition.Enabled = true;
            txtTribel.Enabled = true;
            txtTel.Enabled = true;
            txtMeasure.Enabled = true;
        }

        public void SetDefault()
        {
            txtAddress.Text = "";
            txtCode.Text = "";
            txtCountry.Text = "";
            dtpDateOfBird.Text = "1/1/1900";
            txtLocation.Text = "";
            txtName.Text = "";
            txtPeopleId.Text = "";
            txtPosition.Text = "";
            txtTribel.Text = "";
            txtTel.Text = "";
            txtMeasure.Text = "";
            rdbFeMale.Checked = false;
            rdbMale.Checked = false;
            txtName.Focus();
        }

        private void Form_TImKIem_NhanVien_Load(object sender, EventArgs e)
        {
            bsnv = new BUS_NhanVien();
            DataTable tbl = bsnv.DSNhanVien();
            dataGridView1.DataSource = tbl;
        }

        public void ShowData(int rows)
        {
            txtCode.Text = dataGridView1.Rows[rows].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[rows].Cells[1].Value.ToString();
            txtCountry.Text = dataGridView1.Rows[rows].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[rows].Cells[3].Value.ToString();
            if (dataGridView1.Rows[rows].Cells[4].Value.ToString() == "Nam")
                rdbMale.Checked = true;
            else
                rdbFeMale.Checked = true;
            txtTribel.Text = dataGridView1.Rows[rows].Cells[5].Value.ToString();
            txtPeopleId.Text = dataGridView1.Rows[rows].Cells[6].Value.ToString();
            dtpDateOfBird.Text = dataGridView1.Rows[rows].Cells[7].Value.ToString();
            txtMeasure.Text = dataGridView1.Rows[rows].Cells[8].Value.ToString();
            txtPosition.Text = dataGridView1.Rows[rows].Cells[9].Value.ToString();
            txtLocation.Text = dataGridView1.Rows[rows].Cells[10].Value.ToString();
            txtTel.Text = dataGridView1.Rows[rows].Cells[11].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseTextBox();
            bool check = false;
            int index = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                //txtCode.Text == "" || 
                if (txtCode.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    if (txtName.Text == "" || txtName.Text == dataGridView1.Rows[i].Cells[1].Value.ToString())
                        if (txtCountry.Text == "" || txtCountry.Text == dataGridView1.Rows[i].Cells[2].Value.ToString())
                            if (txtAddress.Text == "" || txtAddress.Text == dataGridView1.Rows[i].Cells[3].Value.ToString())
                                if (txtTribel.Text == "" || txtTribel.Text == dataGridView1.Rows[i].Cells[5].Value.ToString())
                                    if (txtPeopleId.Text == "" || txtPeopleId.Text == dataGridView1.Rows[i].Cells[6].Value.ToString())
                                        //if (Convert.ToDateTime(dtpDateOfBird.Text).ToString("MM/dd/yyyy") == "Monday, January 1, 1990" ||
                                        //    Convert.ToDateTime(dtpDateOfBird.Text).ToString("MM/dd/yyyy") == dataGridView1.Rows[i].Cells[7].Value.ToString())
                                        if (txtMeasure.Text == "" || txtMeasure.Text == dataGridView1.Rows[i].Cells[8].Value.ToString())
                                            if (txtPosition.Text == "" || txtPosition.Text == dataGridView1.Rows[i].Cells[9].Value.ToString())
                                                if (txtLocation.Text == "" || txtLocation.Text == dataGridView1.Rows[i].Cells[10].Value.ToString())
                                                    if (txtTel.Text == "" || txtTel.Text == dataGridView1.Rows[i].Cells[11].Value.ToString())
                                                        if (rdbMale.Checked == true || rdbFeMale.Checked == true)
                                                        {
                                                            if (rdbMale.Checked == true)
                                                            {
                                                                if ("Nam" == dataGridView1.Rows[i].Cells[4].Value.ToString())
                                                                {
                                                                    check = true;
                                                                    index = i;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if ("Nữ" == dataGridView1.Rows[i].Cells[4].Value.ToString())
                                                                {
                                                                    check = true;
                                                                    index = i;
                                                                    break;
                                                                }
                                                            }

                                                        }
                                                        else
                                                        {
                                                            check = true;
                                                            index = i;
                                                            break;
                                                        }
            }
            if (check)
                ShowData(index);
            else
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp ", "Thống báo ", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetDefault();
            OpenTextBox();
        }
    }
}
