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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DDRVASO9\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Integrated Security=True");

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
            DataTable dt = Red("SELECT * FROM QuanLyNhanVien");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Exe("UPDATE QuanLyNhanVien SET  HoTen = '" + HoTen.Text + "', ChucVu = '" + ChucVu.Text + "', TienDoCongViec = '" + TienDoCongViec.Text + "', DanhGia = '" + DanhGia.Text + "' WHERE MaNV = '" + MaNV.Text + "' " );
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exe("DELETE FROM QuanLyNhanVien WHERE MaNV = '" + MaNV.Text + "' ");
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            HoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ChucVu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TienDoCongViec.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DanhGia.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("SELECT * FROM QuanLyNhanVien WHERE MaNV = '" + Tim.Text + "' ");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.ShowDialog();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
