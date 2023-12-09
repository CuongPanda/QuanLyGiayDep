namespace QuanLyCuaHangDayDep
{
    partial class QuanLyKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.MaHang = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TenHang = new System.Windows.Forms.TextBox();
            this.SoLuong = new System.Windows.Forms.TextBox();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Tim = new System.Windows.Forms.Button();
            this.NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.NgayXuat = new System.Windows.Forms.DateTimePicker();
            this.TimKiem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng";
            // 
            // MaHang
            // 
            this.MaHang.Location = new System.Drawing.Point(151, 33);
            this.MaHang.Name = "MaHang";
            this.MaHang.Size = new System.Drawing.Size(238, 22);
            this.MaHang.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 173);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày Xuất";
            // 
            // TenHang
            // 
            this.TenHang.Location = new System.Drawing.Point(151, 60);
            this.TenHang.Name = "TenHang";
            this.TenHang.Size = new System.Drawing.Size(238, 22);
            this.TenHang.TabIndex = 7;
            // 
            // SoLuong
            // 
            this.SoLuong.Location = new System.Drawing.Point(151, 91);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(238, 22);
            this.SoLuong.TabIndex = 8;
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(596, 33);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(133, 24);
            this.Sua.TabIndex = 11;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(596, 63);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(133, 24);
            this.Xoa.TabIndex = 12;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Tim
            // 
            this.Tim.Location = new System.Drawing.Point(596, 177);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(133, 23);
            this.Tim.TabIndex = 13;
            this.Tim.Text = "Tìm";
            this.Tim.UseVisualStyleBackColor = true;
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // NgayNhap
            // 
            this.NgayNhap.Location = new System.Drawing.Point(151, 134);
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Size = new System.Drawing.Size(238, 22);
            this.NgayNhap.TabIndex = 14;
            // 
            // NgayXuat
            // 
            this.NgayXuat.Location = new System.Drawing.Point(151, 162);
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.Size = new System.Drawing.Size(238, 22);
            this.NgayXuat.TabIndex = 15;
            // 
            // TimKiem
            // 
            this.TimKiem.Location = new System.Drawing.Point(408, 177);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(182, 22);
            this.TimKiem.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "Trở lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.NgayXuat);
            this.Controls.Add(this.NgayNhap);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.TenHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MaHang);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyKho";
            this.Text = "QuanLyKho";
            this.Load += new System.EventHandler(this.QuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TenHang;
        private System.Windows.Forms.TextBox SoLuong;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.DateTimePicker NgayNhap;
        private System.Windows.Forms.DateTimePicker NgayXuat;
        private System.Windows.Forms.TextBox TimKiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}