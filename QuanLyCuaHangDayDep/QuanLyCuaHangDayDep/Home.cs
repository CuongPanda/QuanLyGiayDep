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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void QLTTKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("       Hoàn Thành      ", "Thông báo");
            ThongTinKH qlkh = new ThongTinKH();
            this.Hide();
            qlkh.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("       Hoàn Thành      ", "Thông báo");
            QuanLyKho qlk = new QuanLyKho();
            this.Hide();
            qlk.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("       Hoàn Thành      ", "Thông báo");
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            this.Hide();
            qlnv.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("       Hoàn Thành      ", "Thông báo");
            QuanLyBanHang qlbh = new QuanLyBanHang();
            this.Hide();
            qlbh.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("       Hoàn Thành      ", "Thông báo");
            BaoCaoDoanhThu bcdt = new BaoCaoDoanhThu();
            this.Hide();
            bcdt.ShowDialog();
        }
    }
}
