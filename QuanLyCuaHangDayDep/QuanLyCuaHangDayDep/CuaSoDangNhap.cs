using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDayDep
{
    public partial class CuaSoDangNhap : Form
    {
        public CuaSoDangNhap()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if ((DANGNHAP.Text == " ") || (MATKHAU.Text == " "))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo");
            }
            else
            {
                if ((DANGNHAP.Text == "Cuong") || (MATKHAU.Text == "29072003"))
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công", "Thông báo");
                    Home hm = new Home();
                    this.Hide();
                    hm.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Bạn đã đăng nhập không thành công", "Thông báo");

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CuaSoDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
