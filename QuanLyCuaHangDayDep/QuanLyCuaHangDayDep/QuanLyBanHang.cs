using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyCuaHangDayDep
{
    public partial class QuanLyBanHang : Form
    {
        public QuanLyBanHang()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDRVASO9\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");
        private void openCon()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void closeCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        private Boolean Exe(string cmd)
        {
            openCon();
            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeCon();
            return check;
        }
        private DataTable Red(string cmd)
        {
            openCon();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
                throw;
            }
            closeCon();
            return dt;
        }
        private void load()
        {
            DataTable dt = Red("SELECT * FROM QuanLyBanHang");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
        private void QuanLyBanHang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exe("UPDATE QuanLyBanHang SET  NgayLap = '" + NgayLap.Value.ToString("yyyy/MM/dd") + "', NguoiLap = '" + NguoiLap.Text + "', HinhThucTT = '" + HinhThucTT.Text + "' WHERE MaHoaDon = '" + MaHoaDon.Text + "' ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exe("DELETE FROM QuanLyBanHang WHERE MaHoaDon = '" + MaHoaDon.Text + "' ");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaHoaDon.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            NgayLap.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            NguoiLap.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            HinhThucTT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("SELECT * FROM QuanLyBanHang WHERE MaHoaDon = '" + Tim.Text + "' ");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exe("INSERT INTO QuanLyBanHang(MaHoaDon , NgayLap, NguoiLap, HinhThucTT) VALUES(N'" + MaHoaDon.Text + "', N'" + NgayLap.Value.ToString("yyyy/MM/dd") + "' , N'" + NguoiLap.Text + "' , N'" + HinhThucTT.Text + "' ) ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
