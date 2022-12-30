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
    public partial class frmKhamBenh : Form
    {
        public frmKhamBenh()
        {
            InitializeComponent();
        }

        private void richtext1()

        {

            try

            {

                //create an instance of streamreader to read from a file

                //the using statement also closes the streamreader.

                using (StreamReader sr = new StreamReader("D:/lam.docx"))

                {

                    String line;

                    //Read and display lines from the file until the end

                    //of the file is reached.

                    while ((line = sr.ReadLine()) != null)

                    {

                        richTextBox1.AppendText(line);

                    }

                }

            }

            catch (Exception e)

            {

                //let the user know what went wrong

                MessageBox.Show("The file could not be read");

                MessageBox.Show(e.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             OpenFileDialog openFileDialog=new OpenFileDialog();
              if(openFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
              {
                   richtext1();
              }    
              
        }
    }
}
