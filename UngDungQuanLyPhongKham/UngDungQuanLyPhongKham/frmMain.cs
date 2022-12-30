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
    public partial class frmMain : Form
    {
        NhanVien nhanVien;
        bool collapsed;
        Form formMain;
        public frmMain()
        {
            InitializeComponent();
            formMain = new Form();
           
        }
        public frmMain(NhanVien nhanvien):this()
        {
            this.nhanVien = nhanvien;
            btnSetting.Text = nhanVien.chucvu+" - "+ nhanVien.hoten.Split()[nhanVien.hoten.Split().Length-1];
            if(nhanVien.chucvu=="Kế toán")
            {
                btn_HoSoBN.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();
                formMain = new frmQLThanhToan();
                Nav(formMain, content);
            }    
            else
            {
                btn_QuanLyThanhToan.Hide();
                btnThongKe.Hide();
                formMain = new HoSoBenhNhan();
                Nav(formMain, content);
            }    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txtNgayHeThong.Text = now.DayOfWeek + ", " + now.Day + "/" + now.Month + "/" + now.Year;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formMain = new frmTiepDon();
            Nav(formMain, content);
        }

        private void btn_HoSoBN_Click(object sender, EventArgs e)
        {
            formMain = new HoSoBenhNhan();
            Nav(formMain, content);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formMain = new fromDanhMucPhieuKham();
            Nav(formMain, content);
        }
        public void Nav(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size; // for responsive size
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
        public void Nav(Form form)
        {
            form.TopLevel = false;
            form.Size = content.Size; // for responsive size
            content.Controls.Clear();
            content.Controls.Add(form);
            form.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            formMain = new frmLapPhieuKham();
            Nav(formMain, content);
        }

        private void txtAccount_Click(object sender, EventArgs e)
        {
            if(collapsed)
            {
                panelSetting.Height = 100;
               panelSetting.Size=panelSetting.MaximumSize;
                collapsed = false;
            }    
            else
            {
                panelSetting.Height = 100;
                panelSetting.Size = panelSetting.MinimumSize;
                collapsed = true;
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panelSetting.Visible==false)
            {
                panelSetting.Visible = true;
            }    
            else
            {
                panelSetting.Visible = false;
            }    
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }


        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            Nav(this.formMain, content);
        }

        private void btn_QuanLyThanhToan_Click(object sender, EventArgs e)
        {
            formMain = new frmQLThanhToan();
            Nav(formMain, content);
        }
    }
}
