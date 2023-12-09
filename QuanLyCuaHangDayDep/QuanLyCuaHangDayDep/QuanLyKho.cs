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
    public partial class QuanLyKho : Form
    {
        public QuanLyKho()
        {
            InitializeComponent();
        }
        // ket noi csdl
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDRVASO9\SQLEXPRESS;Initial Catalog=QuanLyKho;Integrated Security=True");

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
            DataTable dt = Red("SELECT * FROM QuanLyKho");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }


        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            Exe("UPDATE QuanLyKho SET TenHang = '" + TenHang.Text + "', SoLuong = '" + SoLuong.Text + "', NgayNhap = '" + NgayNhap.Value.ToString("yyyy/MM/dd") + "', NgayXuat = '" + NgayXuat.Value.ToString("yyyy/MM/dd") + "' WHERE MaHang = '" + MaHang.Text + "'  ");
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            Exe("DELETE FROM QuanLyKho WHERE MaHang = '" + MaHang.Text + "' ");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaHang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("SELECT * FROM QuanLyKho WHERE MaHang = '" + Tim.Text + "' ");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
