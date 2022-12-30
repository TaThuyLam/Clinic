using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UngDungQuanLyPhongKham
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }
        private void richtext1(string s)

        {

            try

            {

                //create an instance of streamreader to read from a file

                //the using statement also closes the streamreader.

                using (StreamReader sr = new StreamReader(s))

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
      /*  private string GetWordFileText(string filepath)
        {
            Word.ApplicationClass WordApp = null;
            Word.Document doc = null;
            try
            {
                WordApp = new Word.ApplicationClass();
                doc = WordApp.Documents.Open(filepath, Visible: false);
                string toReturn = doc.Content.Text;
                return toReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                doc.Close();
                WordApp.Quit();
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Word Document|*.docx" })
            {
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                         // GetWordFileText(openFileDialog.FileName);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                      
                   /* object readOnly = false;
                    object visible = true;
                    object save = false;
                    object filename = openFileDialog.FileName;
                    object newTemplate = false;
                    object docType = 0;
                    object missing = Type.Missing;
                    Microsoft.Office.Interop.Word.Document document;
                    Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application()
                    {
                        Visible = false
                    };
                    document = application.Documents.Open(ref filename, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                    document.ActiveWindow.Selection.WholeStory();
                    document.ActiveWindow.Selection.Copy();
                    IDataObject dataObject = Clipboard.GetDataObject();
                    richTextBox1.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                    application.Quit(ref missing, ref missing, ref missing);
*/
                }
            }
            
            
        }
    }
}
