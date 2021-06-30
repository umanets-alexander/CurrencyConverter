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
        public string CharCode_1 = "USD";
        public int Nominal_1 = 0;
        public string Name_1 = "";
        public double Value_1 = 0.0;
        public double Previous_1 = 0.0;
        public string CharCode_2 = "EUR";
        public int Nominal_2 = 0;
        public string Name_2 = "";
        public double Value_2 = 0.0;
        public double Previous_2 = 0.0;
        public string CharCode_3 = "";
        public int Nominal_3 = 0;
        public string Name_3 = "";
        public double Value_3 = 0.0;
        public double Previous_3 = 0.0;
        public bool darkmode = false;
        public double text_3 = 0.0;

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
            label_1.Text = CharCode_1;
            label_2.Text = CharCode_2;
        }

        private void screenconvert (bool result)
        {
            panelbottom.Visible = paneltop.Visible = panelleft.Visible = panelright.Visible = panelcenter.Visible = result;
        }

        private async void screenloading(string name)
        {
            PictureBox picloading = new PictureBox();
            picloading.Image = Image.FromFile(Path.GetFullPath(@"icon\loading.gif"));
            picloading.Dock = DockStyle.Fill;
            picloading.SizeMode = PictureBoxSizeMode.CenterImage;
            this.Controls.Add(picloading);
            await Task.Delay(3000);
            picloading.Dispose();
            if (name == "converter")
                screenconvert(true);
            else if (name == "data")
                screenconvert(true);
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
            screenloading("converter");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screenconvert(false);
            screenloading("converter");
        }

        private void text_1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void picswap_Click_1(object sender, EventArgs e)
        {
            CharCode_3 = CharCode_1;
            Nominal_3 = Nominal_1;
            Name_3 = Name_1;
            Value_3 = Value_1;
            Previous_3 = Previous_1;

            CharCode_1 = CharCode_2;
            Nominal_1 = Nominal_2;
            Name_1 = Name_2;
            Value_1 = Value_2;
            Previous_1 = Previous_2;

            CharCode_2 = CharCode_3;
            Nominal_2 = Nominal_3;
            Name_2 = Name_3;
            Value_2 = Value_3;
            Previous_2 = Previous_3;

            if (text_1.Text == String.Empty)
                text_1.Text = "0";
            if (text_2.Text == String.Empty)
                text_2.Text = "0";
            text_3 = double.Parse(text_1.Text);
            text_1.Text = text_2.Text;
            text_2.Text = Convert.ToString(text_3);
            label_1.Text = CharCode_1;
            label_2.Text = CharCode_2;
        }

        private void text_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && (((sender as TextBox).Text.IndexOf(',') != -1) || (sender as TextBox).Text.Length == 0))
            {
                e.Handled = true;
            }
        }

        private void text_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && (((sender as TextBox).Text.IndexOf(',') != -1) || (sender as TextBox).Text.Length == 0))
            {
                    e.Handled = true;
            }
        }
    }
}
