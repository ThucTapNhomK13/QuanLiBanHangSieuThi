using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using BUS;
using DTO_Model;


namespace GUI
{
    public partial class Form_TImKiem_KhachHang : Form
    {
        BUS_KhachHang dskh = new BUS_KhachHang();

        public Form_TImKiem_KhachHang()
        {
            InitializeComponent();
        }

        #region EX
        //public void OpenTextBox()
        //{
        //    txtCodeId.Enabled = true;
        //    txtName.Enabled = true;
        //    txtPeopleId.Enabled = true;
        //    txtAddress.Enabled = true;
        //    txtTel.Enabled = true;
        //    rdbFeMale.Enabled = true;
        //    rdbMale.Enabled = true;
        //    dtpDateOfBird.Enabled = true;
        //}

        //public void CloseTextBox()
        //{
        //    txtCodeId.Enabled = false;
        //    txtName.Enabled = false;
        //    txtPeopleId.Enabled = false;
        //    txtAddress.Enabled = false;
        //    txtTel.Enabled = false;
        //    rdbFeMale.Enabled = false;
        //    rdbMale.Enabled = false;
        //    dtpDateOfBird.Enabled = false;
        //}

        //public void SetDefault()
        //{
        //    txtCodeId.Text = "";
        //    txtName.Text = "";
        //    txtPeopleId.Text = "";
        //    txtAddress.Text = "";
        //    txtTel.Text = "";
        //    rdbFeMale.Checked = false;
        //    rdbMale.Checked = false;
        //    dtpDateOfBird.Text = "1/1/1990";
        //}

        //public void ShowData(int rows)
        //{
        //    txtCodeId.Text = dataGridView1.Rows[rows].Cells[0].Value.ToString();
        //    txtName.Text = dataGridView1.Rows[rows].Cells[1].Value.ToString();
        //    dtpDateOfBird.Text = dataGridView1.Rows[rows].Cells[2].Value.ToString();
        //    if (dataGridView1.Rows[rows].Cells[3].Value.ToString() == "Nam")
        //        rdbMale.Checked = true;
        //    else
        //        rdbFeMale.Checked = true;
        //    txtPeopleId.Text = dataGridView1.Rows[rows].Cells[4].Value.ToString();
        //    txtAddress.Text = dataGridView1.Rows[rows].Cells[5].Value.ToString();
        //    txtTel.Text = dataGridView1.Rows[rows].Cells[6].Value.ToString();
        //}

        #endregion

        private void Form_TImKiem_KhachHang_Load(object sender, EventArgs e)
        {
            DataTable tbl = dskh.DSKhachHang();
            dataGridView1.DataSource = tbl;
            //CloseTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CloseTextBox();
            #region Ex
            //if (txtName.Text == " " || string.IsNullOrEmpty(txtName.Text))
            //{
            //    MessageBox.Show("Bạn chưa nhập dữ liệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //if (txtCodeId.Text == " " || string.IsNullOrEmpty(txtCodeId.Text))
            //{
            //    MessageBox.Show("Bạn chưa nhập dữ liệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //if (txtAddress.Text == " " || string.IsNullOrEmpty(txtAddress.Text))
            //{
            //    MessageBox.Show("Bạn chưa nhập dữ liệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //if (txtPeopleId.Text == " " || string.IsNullOrEmpty(txtPeopleId.Text))
            //{
            //    MessageBox.Show("Bạn chưa nhập dữ liệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //if (txtTel.Text == " " || string.IsNullOrEmpty(txtTel.Text))
            //{
            //    MessageBox.Show("Bạn chưa nhập dữ liệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //bool check = false;
            //int index = 0;
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if (txtCodeId.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
            //        if (txtName.Text == dataGridView1.Rows[i].Cells[1].Value.ToString())
            //            //if (dtpDateOfBird.Text == dataGridView1.Rows[i].Cells[2].Value.ToString())
            //            if (txtPeopleId.Text == dataGridView1.Rows[i].Cells[4].Value.ToString())
            //                if (txtAddress.Text == dataGridView1.Rows[i].Cells[5].Value.ToString())
            //                    if (txtTel.Text == dataGridView1.Rows[i].Cells[6].Value.ToString())
            //                        if (rdbMale.Checked == true || rdbFeMale.Checked == true)
            //                        {
            //                            if (rdbMale.Checked == true)
            //                            {
            //                                if ("Nam" == dataGridView1.Rows[i].Cells[4].Value.ToString())
            //                                {
            //                                    check = true;
            //                                    index = i;
            //                                }
            //                            }
            //                            else
            //                            {
            //                                if ("Nữ" == dataGridView1.Rows[i].Cells[4].Value.ToString())
            //                                {
            //                                    check = true;
            //                                    index = i;
            //                                    break;
            //                                }
            //                            }

            //                        }
            //                        else
            //                        {
            //                            check = true;
            //                            index = i;
            //                            break;
            //                        }
            //}
            //if (check)
            //    ShowData(index);
            //else
            //    MessageBox.Show("Không tìm thấy dữ liệu phù hợp ", "Thống báo ", MessageBoxButtons.OK);
            #endregion

            string txt = txtTKKhachHang.Text.Trim();
            if (txt == " " || string.IsNullOrEmpty(txt))
            {
                dataGridView1.DataSource = dskh.DSKhachHang();
            }
            else
            {
                dataGridView1.DataSource = dskh.DTTimKiemKH(txt);
            }
            


            
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //SetDefault();
        //    //OpenTextBox();
        //    //button1.Enabled = true;   
        //}
    }
}
