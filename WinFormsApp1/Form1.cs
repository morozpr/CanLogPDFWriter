using iText.Html2pdf;
using HtmlAgilityPack;
using System.Diagnostics;
using static WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string[]? imgArray;

        public string[]? imgsHTML;


        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Multiselect = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
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
            imgArray = [];
        }

        private void loadIMGBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                foreach (var file in openFileDialog1.FileNames) 
                {
                    ImgsByte item = new()
                    {
                        FileByte = File.ReadAllBytes(file),
                        FilePath = file
                    };

                    using Image img = Image.FromFile(file);
                    using MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    byte[] bytes = ms.ToArray();
                    

                    imgsHTML.Append("data:image/" + Path.GetExtension(item.FilePath).TrimStart('.') + ";base64," + Convert.ToBase64String(bytes));
                }
            }
            
            //foreach (var file in imgArray) { label11.Text = string.Join(" ", file); }

        }
    }
}
