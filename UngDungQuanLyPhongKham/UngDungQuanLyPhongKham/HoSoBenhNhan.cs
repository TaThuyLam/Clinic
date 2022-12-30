using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyPhongKham
{
    public partial class HoSoBenhNhan : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VC5O58E8\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string mabn;
        string hoten;
        string diachi;
        string ngaysinh;
        string gioitinh;
        string sodienthoai;
        void getData(String s)
        {
            SqlCommand command = new SqlCommand(s, con);
            adapter.SelectCommand = command;
        }

        void loadData()
        {
            SqlCommand com = new SqlCommand("exec sp_DanhSachHoSoBenhNhan", con);
            adapter.SelectCommand = com;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode =  DataGridViewAutoSizeColumnsMode.Fill;



        }
        void getBenhNhan()
        {
            mabn = txtMaBN_HSBN.Text;
            hoten = txtHoTen_HSBN.Text;
            diachi = txtDiaChi_HSBN.Text;
            ngaysinh = dtNgaySinh_HSBN.Text;
            gioitinh = cbGioiTinh_BN.Text;
            sodienthoai = txtSDT_HSBN.Text;
        }
        void UpdateData(string sql)
        {
          
            if (hoten == "" || sodienthoai == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
            else if (!(gioitinh == "Nam" || gioitinh == "Nữ"))
            {
                MessageBox.Show("Chỉ được chọn giới tính là Nam hoặc Nữ!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!!!");
                    loadData();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }

                con.Close();
            }
        }
        public HoSoBenhNhan()
        {
            InitializeComponent();
         

        }

        private void HoSoBenhNhan_Load(object sender, EventArgs e)
        {
            loadData();
            List<string> strings = new List<string>() { "Nam", "Nữ" };
            cbGioiTinh_BN.DataSource = strings;
        }

        private void btnAdd_BenhNhan_Click(object sender, EventArgs e)
        {
            getBenhNhan();
            string sql = "sp_ThemBenhNhan N'" + hoten + "', '" + ngaysinh + "', N'" + diachi + "', N'" + gioitinh + "',' " + sodienthoai + "'";
            UpdateData(sql);

        }

        private void btnDelete_HSBN_Click(object sender, EventArgs e)
        {
            mabn = txtMaBN_HSBN.Text;
            if (mabn=="")
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân muốn xóa");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "sp_XoaBenhNhan "+mabn;
                    SqlCommand sqlCommand = new SqlCommand(sql, con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!!!");
                    loadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }

                con.Close();
            }
        }

        private void btnCancel_BenhNhan_Click(object sender, EventArgs e)
        {
            txtMaBN_HSBN.Text = "";
            txtHoTen_HSBN.Text="";
            txtDiaChi_HSBN.Text="";
            dtNgaySinh_HSBN.Text="";
            cbGioiTinh_BN.Text="Nữ";
            txtSDT_HSBN.Text="";
            loadData();
        }
            private void btnPrint_HSBN_Click(object sender, EventArgs e)
        {
            getBenhNhan();
            string sql = "sp_ChinhSuaBenhNhan "+mabn+", N'" + hoten + "', '" + ngaysinh + "', N'" + diachi + "', N'" + gioitinh + "',' " + sodienthoai + "'";
            UpdateData(sql);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            string search = txtSearch_HSBN.Text;
            if(search == "")
            {
                loadData();
            }
            else
            {
                getData("sp_TimBenhNhan " + search);
                table.Clear();

                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
         

        }

        private void btnSearch_HSBN_Click(object sender, EventArgs e)
        {
            
            string search = txtSearch_HSBN.Text;
            if(search !="")
            {
                getData("sp_TimBenhNhan " + search);
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }    
     

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaBN_HSBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtMaBN_HSBN.Text = Convert.ToString(row.Cells[0].Value);
            txtHoTen_HSBN.Text = Convert.ToString(row.Cells[1].Value);
            dtNgaySinh_HSBN.Text = Convert.ToString(row.Cells[2].Value);
            txtDiaChi_HSBN.Text= Convert.ToString(row.Cells[3].Value);
            cbGioiTinh_BN.Text = Convert.ToString(row.Cells[4].Value);
            txtSDT_HSBN.Text = Convert.ToString(row.Cells[5].Value);
        }

        private void txtSDT_HSBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
