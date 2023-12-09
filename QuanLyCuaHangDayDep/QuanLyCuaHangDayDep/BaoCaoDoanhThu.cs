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
    public partial class BaoCaoDoanhThu : Form
    {
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDRVASO9\SQLEXPRESS;Initial Catalog=BaoCaoDoanhThu;Integrated Security=True");
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
            DataTable dt = Red("SELECT * FROM BaoCaoDoanhThu");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exe("INSERT INTO BaoCaoDoanhThu(TongTien , NgayBatDau, NgayKetThuc, DanhGia) VALUES (N'" + TongTien.Text + "', N'" + NgayBatDau.Value.ToString("yyyy/MM/dd") + "' ,N'" + NgayKetThuc.Value.ToString("yyyy/MM/dd") + "' , N'" + DanhGia.Text + "' ) ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exe("UPDATE BaoCaoDoanhThu SET  N'" + NgayBatDau.Value.ToString("yyyy/MM/dd") + "' ,N'" + NgayKetThuc.Value.ToString("yyyy/MM/dd") + "' , N'" + DanhGia.Text + "' WHERE TongTien = '" + TongTien.Text + "' ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exe("DELETE FROM BaoCaoDoanhThu WHERE TongTien = '" + TongTien.Text + "' ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("SELECT * FROM BaoCaoDoanhThu WHERE DanhGia = '" + Tim.Text + "' ");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TongTien.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            NgayBatDau.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            NgayKetThuc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DanhGia.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
