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
    public partial class Form_TImKiem_KhachHang : Form
    {
        BUS_KhachHang dskh = null;

        public Form_TImKiem_KhachHang()
        {
            InitializeComponent();
        }

        public void OpenTextBox()
        {
            txtCodeId.Enabled = true;
            txtName.Enabled = true;
            txtPeopleId.Enabled = true;
            txtAddress.Enabled = true;
            txtTel.Enabled = true;
            rdbFeMale.Enabled = true;
            rdbMale.Enabled = true;
            dtpDateOfBird.Enabled = true;
        }

        public void CloseTextBox()
        {
            txtCodeId.Enabled = false;
            txtName.Enabled = false;
            txtPeopleId.Enabled = false;
            txtAddress.Enabled = false;
            txtTel.Enabled = false;
            rdbFeMale.Enabled = false;
            rdbMale.Enabled = false;
            dtpDateOfBird.Enabled = false;
        }

        public void SetDefault()
        {
            txtCodeId.Text = "";
            txtName.Text = "";
            txtPeopleId.Text = "";
            txtAddress.Text = "";
            txtTel.Text = "";
            rdbFeMale.Checked = false;
            rdbMale.Checked = false;
            dtpDateOfBird.Text = "1/1/1990";
        }

        public void ShowData(int rows)
        {
            txtCodeId.Text = dataGridView1.Rows[rows].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[rows].Cells[1].Value.ToString();
            dtpDateOfBird.Text = dataGridView1.Rows[rows].Cells[2].Value.ToString();
            if (dataGridView1.Rows[rows].Cells[3].Value.ToString() == "Nam")
                rdbMale.Checked = true;
            else
                rdbFeMale.Checked = true;
            txtPeopleId.Text = dataGridView1.Rows[rows].Cells[4].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[rows].Cells[5].Value.ToString();
            txtTel.Text = dataGridView1.Rows[rows].Cells[6].Value.ToString();
        }

        public void LoadData()
        {
            dskh = new BUS_KhachHang();
            DataTable tbl = dskh.DSKhachHang();
            dataGridView1.DataSource = tbl;
            OpenTextBox();
        }
        private void Form_TImKiem_KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            OpenTextBox();
            List<KhachHang> classroomsearch = new List<KhachHang>();
            KhachHang customer = null;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (txtCodeId.Text == dataGridView1.Rows[i].Cells[0].Value.ToString() || txtCodeId.Text == "" )
                    if (txtName.Text == dataGridView1.Rows[i].Cells[1].Value.ToString() || txtName.Text == "" || dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(txtName.Text) == true)
                        if (dtpDateOfBird.Text == dataGridView1.Rows[i].Cells[2].Value.ToString())
                            if (txtPeopleId.Text == dataGridView1.Rows[i].Cells[4].Value.ToString() || txtPeopleId.Text == "" || dataGridView1.Rows[i].Cells[4].Value.ToString().Contains(txtPeopleId.Text) == true)
                                if (txtAddress.Text == dataGridView1.Rows[i].Cells[5].Value.ToString() || txtAddress.Text == "" || dataGridView1.Rows[i].Cells[5].Value.ToString().Contains(txtAddress.Text) == true)
                                    if (txtTel.Text == dataGridView1.Rows[i].Cells[6].Value.ToString() || txtTel.Text == "" || dataGridView1.Rows[i].Cells[6].Value.ToString().Contains(txtTel.Text) == true)
                                    {
                                        if (rdbMale.Checked == true && "Nam" == dataGridView1.Rows[i].Cells[3].Value.ToString())
                                        {
                                            customer = new KhachHang(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString()
                                                , DateTime.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()), dataGridView1.Rows[i].Cells[3].Value.ToString()
                                                , dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString()
                                                , dataGridView1.Rows[i].Cells[6].Value.ToString());
                                            classroomsearch.Add(customer);

                                        }
                                        else if (rdbFeMale.Checked == true && "Nữ" == dataGridView1.Rows[i].Cells[3].Value.ToString())
                                        {
                                            customer = new KhachHang(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString()
                                                , DateTime.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()), dataGridView1.Rows[i].Cells[3].Value.ToString()
                                                , dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString()
                                                , dataGridView1.Rows[i].Cells[6].Value.ToString());
                                            classroomsearch.Add(customer);

                                        }
                                        else if (rdbDefault.Checked == true)

                                        {
                                            customer = new KhachHang(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString()
                                                        , DateTime.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()), dataGridView1.Rows[i].Cells[3].Value.ToString()
                                                        , dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString()
                                                        , dataGridView1.Rows[i].Cells[6].Value.ToString());
                                            classroomsearch.Add(customer);
                                        }
                                    }

            }
            if (dataGridView1.DataSource == null)
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp ", "Thống báo ", MessageBoxButtons.OK);
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = classroomsearch;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetDefault();
            OpenTextBox();
        }
    }
}
