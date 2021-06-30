using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class ConverterForm : Form
    {
        public string CharCode_1 = "";
        public int Nominal_1 = 0;
        public string Name_1 = "";
        public double Value_1 = 0.0;
        public double Previous_1 = 0.0;
        public string CharCode_2 = "";
        public int Nominal_2 = 0;
        public string Name_2 = "";
        public double Value_2 = 0.0;
        public double Previous_2 = 0.0;
        public bool darkmode = false;
        public bool swap = false;
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public ConverterForm()
        {
            InitializeComponent();
            ImageDownload.DownloadImageGitHub();
            this.Icon = new Icon(Path.GetFullPath(@"icon\exchange.ico"));
            if (darkmode == false)
                picmode.Image = Image.FromFile(Path.GetFullPath(@"icon\lightmode.png"));
            else
                picmode.Image = Image.FromFile(Path.GetFullPath(@"icon\darkmode.png"));
            picswap.Image = Image.FromFile(Path.GetFullPath(@"icon\swap.png"));
            picgithub.Image = Image.FromFile(Path.GetFullPath(@"icon\github.png"));
        }

        private void screenconvert (bool result)
        {
            panelbottom.Visible = paneltop.Visible = panelleft.Visible = panelright.Visible = panelcenter.Visible = result;
        }

        private void screenloading ()
        {
            PictureBox picloading = new PictureBox();
            picloading.Image = Image.FromFile(Path.GetFullPath(@"icon\loading.gif"));
            picloading.Dock = DockStyle.Fill;
            picloading.SizeMode = PictureBoxSizeMode.CenterImage;
            this.Controls.Add(picloading);
            System.Threading.Thread.Sleep(5000);
            picloading.Dispose();
        }

        private void picgithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/umanets-alexander/CurrencyConverter");
        }

        private void picmode_Click(object sender, EventArgs e)
        {
            if (darkmode == false)
            {
                darkmode = true;
                picmode.Image = Image.FromFile(Path.GetFullPath(@"icon\darkmode.png"));
            }
            else
            {
                darkmode = false;
                picmode.Image = Image.FromFile(Path.GetFullPath(@"icon\lightmode.png"));
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            screenconvert(false);
            screenloading();
        }
    }
}
