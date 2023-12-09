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

namespace QuanLyCuaHangDayDep
{
    public partial class ThongTinKH : Form
    {
        public ThongTinKH()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDRVASO9\SQLEXPRESS;Initial Catalog=""Quản lý cửa hàng dày dép"";Integrated Security=True");
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
            DataTable dt = Red("SELECT * FROM QuanLyThongTin");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
        private void ThongTinKH_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaTK.ResetText();
            HoTen.ResetText();
            NamSinh.ResetText();
            SDT.ResetText();
            Email.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exe("INSERT INTO QuanLyThongTin(MaTK , HoTen, NamSinh, SDT, Email) VALUES(N'" + MaTK.Text + "', N'" + HoTen.Text + "' , N'" + NamSinh.Text + "' , N'" + SDT.Text + "' , N'" + Email.Text + "') ");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exe("UPDATE QuanLyThongTin SET HoTen = N'" + HoTen.Text + "', NamSinh = N'" + NamSinh.Text + "', SDT = N'" + SDT.Text + "', Email = N'" + Email.Text + "' WHERE MaTK = '" + MaTK.Text + "'  ");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaTK.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            HoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            NamSinh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            SDT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Email.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Exe("DELETE FROM QuanLyThongTin WHERE MaTK = '" + MaTK.Text + "' ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("SELECT * FROM QuanLyThongTin WHERE MaTK = '" + TimKiem.Text + "' ");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
