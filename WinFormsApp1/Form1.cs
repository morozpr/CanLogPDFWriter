using iText.Html2pdf;
using HtmlAgilityPack;
using System.Diagnostics;

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
            string dataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CanLogPDFWriter");

            if (!Directory.Exists(dataDir))
            {
                Directory.CreateDirectory(dataDir);
            }


            CanLogInfo canLogInfo = new CanLogInfo();

            canLogInfo.Model = textBox1.Text;
            canLogInfo.Module = textBox2.Text;
            canLogInfo.Year = textBox3.Text;
            canLogInfo.Rev = textBox4.Text;
            canLogInfo.Version = textBox5.Text;
            canLogInfo.ProgramN = textBox6.Text;
            canLogInfo.Date = dateTimePicker1.Value.ToShortDateString();

            string fileName = $"{canLogInfo.Module}_{canLogInfo.Model}_{canLogInfo.Year}_{canLogInfo.Version}_{canLogInfo.Rev}_{canLogInfo.Date}.pdf"; // ƒŒƒ≈À¿“‹
            string html = File.ReadAllText("template.html");

            html = html.Replace("<<[Model]>>", canLogInfo.Model).Replace("<<[Module]>>", canLogInfo.Module)
            .Replace("<<[Year]>>", canLogInfo.Year)
            .Replace("<<[Rev]>>", canLogInfo.Rev)
            .Replace("<<[Version]>>", canLogInfo.Version)
            .Replace("<<[ProgramN]>>", canLogInfo.ProgramN)
            .Replace("<<[Date]>>", canLogInfo.Date);

            HtmlConverter.ConvertToPdf(html, new FileStream(Path.Combine(dataDir, fileName), FileMode.Create));

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

        private void loadIMGBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using Image img = Image.FromFile(openFileDialog1.FileName);
                using MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                byte[] data = ms.ToArray();

            }
        }
    }
}
