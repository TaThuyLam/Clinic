using Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyPhongKham
{
    public partial class frmMain_Admin : Form
    {
        Form formmain;
        NhanVien nhanvien;
        public frmMain_Admin()
        {
            InitializeComponent();
           

        }

        public frmMain_Admin(NhanVien nhanVien):this()
        {
            nhanvien=nhanVien;
            btn_SettinhAdmin.Text = nhanvien.chucvu + " - " + nhanvien.hoten.Split()[nhanvien.hoten.Split().Length - 1];
        }

        private void frmMain_Admin_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txt_Date.Text = now.DayOfWeek + ", " + now.Day + "/" + now.Month + "/" + now.Year;
            panel4.Visible=false;
            formmain = new frmQLDichVu();
            Nav(formmain, panel3);

        }
        public void Nav(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size; // for responsive size
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        private void btn_SettinhAdmin_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void btn_LogoutAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btn_QLDV_Click(object sender, EventArgs e)
        {
           formmain = new frmQLDichVu();
            Nav(formmain, panel3);
        }

        private void btn_QLT_Click(object sender, EventArgs e)
        {
            formmain = new frmQLThuoc();
            Nav(formmain, panel3);
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            formmain = new frmQlNhanVien();
            Nav(formmain, panel3);
        }

        private void frmMain_Admin_SizeChanged(object sender, EventArgs e)
        {
           Nav(this.formmain, panel3);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMain_Admin_Load(sender, e);
        }
    }
}
