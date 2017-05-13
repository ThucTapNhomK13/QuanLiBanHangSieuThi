using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using BUS;
using DTO_Model;


namespace GUI
{
    public partial class Form_Login : Form
    {
        
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUS_User us = new BUS_User();
            List<DangNhap> dn = us.dangNhap();
            bool test = false;
            for (int i = 0; i <dn.Count; i++)
            {
                if (dn[i].tendangnhap.ToString() == txtUser.Text.ToString() &&
                    dn[i].matkhau.ToString() == txtPassWords.Text.ToString())
                {
                    test = true;                                     
                }                            
            }
            if(test)
            {
                this.Hide();
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                Form_Main main = new Form_Main();
                main.ShowDialog();
                this.Show();
            }              
            else
            {
                MessageBox.Show("Bạn đã điền sai tên đăng nhập hoặc mật khẩu ! ", "Thông báo", MessageBoxButtons.OK);
                setNull();
            }           
        }

        void setNull()
        {
            txtPassWords.Text = "";
            txtUser.Text = "";
            txtUser.Focus(); // Dat con tro vao o co cai nay !!!
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            setNull();
        }
    }
}
