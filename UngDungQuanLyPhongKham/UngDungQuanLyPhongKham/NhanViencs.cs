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

namespace AppQLPK
{
    public partial class NhanViencs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VC5O58E8\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VC5O58E8\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string manv;
        string hoten;
        string trinhdo;
        string chuyenmon;
        string chucvu;
        
        void getData(String s)
        {
            SqlCommand command = new SqlCommand(s, con);
            adapter.SelectCommand = command;
        }

        void loadData()
        {
            SqlCommand com = new SqlCommand(" sp_DanhSachNhanVien", con);
            adapter.SelectCommand = com;
            table.Clear();
            adapter.Fill(table);
            dtNhanVien_dm.DataSource = table;
            dtNhanVien_dm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }
        void getNhanVien()
        {
            manv = txtmanv_dm.Text;
            hoten = txtHoten_dm.Text;
            trinhdo = txtTrinhDo_dm.Text;
            chuyenmon = txtChuyenMon_dm.Text;
            chucvu = txtChucVu_dm.Text;
        }
        void UpdateData(string sql)
        {

            if (hoten == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
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
        public NhanViencs()
        {
            InitializeComponent();
        }

        private void dtNhanVien_dm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
         
        }

        private void dtNhanVien_dm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtNhanVien_dm.Rows[e.RowIndex];
            txtmanv_dm.Text = Convert.ToString(row.Cells[0].Value);
            txtHoten_dm.Text = Convert.ToString(row.Cells[1].Value);
            txtChucVu_dm.Text = Convert.ToString(row.Cells[2].Value);
            txtTrinhDo_dm.Text = Convert.ToString(row.Cells[3].Value);
            txtChuyenMon_dm.Text = Convert.ToString(row.Cells[4].Value);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NhanViencs_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_dm_Click(object sender, EventArgs e)
        {
            getNhanVien();
            string sql = "sp_ThemNhanVien N'" + hoten + "', N'" + chucvu + "', N'" + chuyenmon + "',N'"+trinhdo+"'";
            UpdateData(sql);

        }
    }
}
