using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using UngDungQuanLyPhongKham;
using System.Reflection.PortableExecutable;

namespace Project
{
    public partial class frmLogin : Form
    {
        Database db;
        public frmLogin()
        {
            InitializeComponent();
            db = new Database();
            txtUsername.Text = "BuiThanhXuan";
            txtPassword.Text = "123456789";
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-VC5O58E8\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True");
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            if (user == ""||pass=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                try
                {
                    connection.Open();
                    NhanVien nhanvien = new NhanVien();

                    string sql = "sp_KiemTraDangNhap " + user + "," + pass;
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader datareader = cmd.ExecuteReader();
                    
                        while (datareader.Read())
                        {
                            nhanvien = new NhanVien(datareader.GetInt32(0), datareader.GetString(1), datareader.GetString(2), datareader.GetString(3), datareader.GetString(4), datareader.GetString(5), datareader.GetString(6));
                        }
                       
                    if (nhanvien!=null)
                    {
                       // db.UpdateData("create login " + nhanvien.taikhoan + " with password ='" + nhanvien.matkhau + "'");
                        if(nhanvien.chucvu=="Admin")
                        {
                            this.Hide();
                            frmMain_Admin main = new frmMain_Admin(nhanvien);
                            main.Show();
                        }  
                        else
                        {
                            this.Hide();
                            frmMain main = new frmMain(nhanvien);
                            main.Show();
                        }    
                       
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!!!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }

                connection.Close();
            }
          

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
