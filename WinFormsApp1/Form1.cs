using PdfSharp;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using iText;
using iText.Html2pdf;
using System.Web;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            genPDF();
        }

        public void genPDF()
        {
            string dataDir = Directory.GetCurrentDirectory();


            CanLogInfo canLogInfo = new CanLogInfo();

            canLogInfo.Model = textBox1.Text;
            canLogInfo.Module = textBox2.Text;
            canLogInfo.Year = textBox3.Text;
            canLogInfo.Rev = textBox4.Text;
            canLogInfo.Version = textBox5.Text;
            canLogInfo.ProgramN = textBox6.Text;
            canLogInfo.Date = dateTimePicker1.Text;

            string html = File.ReadAllText("template.html");

            File.WriteAllText("temp.html", html);

            html.Replace("<<[Model]>>", canLogInfo.Model);
            html.Replace("<<[Module]>>", canLogInfo.Module);
            html.Replace("<<[Year]>>", canLogInfo.Year);
            html.Replace("<<[Rev]>>", canLogInfo.Rev);
            html.Replace("<<[Version]>>", canLogInfo.Version);
            html.Replace("<<[ProgramN]>>", canLogInfo.ProgramN);
            html.Replace("<<[Date]>>", canLogInfo.Date);


            HtmlConverter.ConvertToPdf(html, new FileStream("output.pdf", FileMode.Create));

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            dateTimePicker1.ResetText();
        }
    }
}
