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
                picmode.Image = Image.FromFile(Path.GetFullPath(@"icon\darkmode.png"));
            else
                picmode.Image = Image.FromFile(Path.GetFullPath(@"icon\lightmode.png"));
            colormode(darkmode);
            picswap.Image = Image.FromFile(Path.GetFullPath(@"icon\swap.png"));
            picgithub.Image = Image.FromFile(Path.GetFullPath(@"icon\github.png"));
            JSONConnect.connectJSON();
            Variables.value("USD", ref Nominal_1, ref Name_1, ref Value_1, ref Previous_1);
            Variables.value("EUR", ref Nominal_2, ref Name_2, ref Value_2, ref Previous_2);
            label_1.Text = CharCode_1;
            label_2.Text = CharCode_2;
            course();
            tooltips(darkmode);
        }

        private void tooltips (bool result)
        {
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.OwnerDraw = true;
            if (result == false)
            {
                toolTip.BackColor = ColorTranslator.FromHtml("#E0E6C8");
                toolTip.ForeColor = ColorTranslator.FromHtml("#33363B");
            }
            else
            {
                toolTip.BackColor = ColorTranslator.FromHtml("#333230");
                toolTip.ForeColor = ColorTranslator.FromHtml("#999795");
            }
            toolTip.SetToolTip(picstatus_1, "На сегодня курс 1 " + CharCode_1 + " составляет " + Math.Round(((Value_1 / Nominal_1) / (Value_2 / Nominal_2)), 2) + " " + CharCode_2 + ", вчера этот курс составлял " + Math.Round(((Previous_1 / Nominal_1) / (Previous_2 / Nominal_2)), 2) + " " + CharCode_2 + ".");
            toolTip.SetToolTip(picstatus_2, "На сегодня курс 1 " + CharCode_2 + " составляет " + Math.Round(((Value_2 / Nominal_2) / (Value_1 / Nominal_1)), 2) + " " + CharCode_1 + ", вчера этот курс составлял " + Math.Round(((Previous_2 / Nominal_2) / (Previous_1 / Nominal_1)), 2) + " " + CharCode_1 + ".");
            
        }

        private void course()
        {
            if (((Value_1 / Nominal_1) / (Value_2 / Nominal_2)) > ((Previous_1 / Nominal_1) / (Previous_2 / Nominal_2)))
                picstatus_1.Image = Image.FromFile(Path.GetFullPath(@"icon\up.png"));
            else
                picstatus_1.Image = Image.FromFile(Path.GetFullPath(@"icon\down.png"));
            if (((Value_2 / Nominal_2) / (Value_1 / Nominal_1)) > ((Previous_2 / Nominal_2) / (Previous_1 / Nominal_1)))
                picstatus_2.Image = Image.FromFile(Path.GetFullPath(@"icon\up.png"));
            else
                picstatus_2.Image = Image.FromFile(Path.GetFullPath(@"icon\down.png"));
        }

        private void screenconvert (bool result)
        {
            panelbottom.Visible = paneltop.Visible = panelleft.Visible = panelright.Visible = panelcenter.Visible = result;
        }

        private async void screenloading(string name, string values, bool first)
        {
            PictureBox picloading = new PictureBox();
            picloading.Image = Image.FromFile(Path.GetFullPath(@"icon\loading.gif"));
            picloading.Dock = DockStyle.Fill;
            picloading.SizeMode = PictureBoxSizeMode.CenterImage;
            this.Controls.Add(picloading);
            await Task.Delay(500);
            picloading.Dispose();
            if (name == "converter")
                screenconvert(true);
            else if (name == "table")
            {
                screenconvert(false);
                screentable(values, first);
            }
        }

        private void screentable(string values, bool first)
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ReadOnly = false;
            dataGridView.Columns.Add("Names", "Название");
            dataGridView.Columns.Add("Codes", "Код");
            dataGridView.Columns.Add("Check", "Выбран");
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[1].Width = 50;
            dataGridView.Columns[2].Width = 70;
            dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView.ColumnHeadersHeight = 30;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.Rows.Add("Российский рубль", "RUB");
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.AUD.Name, JSONConnect.DataCurrency.Valute.AUD.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.AZN.Name, JSONConnect.DataCurrency.Valute.AZN.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.GBP.Name, JSONConnect.DataCurrency.Valute.GBP.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.AMD.Name, JSONConnect.DataCurrency.Valute.AMD.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.BYN.Name, JSONConnect.DataCurrency.Valute.BYN.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.BGN.Name, JSONConnect.DataCurrency.Valute.BGN.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.BRL.Name, JSONConnect.DataCurrency.Valute.BRL.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.HUF.Name, JSONConnect.DataCurrency.Valute.HUF.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.HKD.Name, JSONConnect.DataCurrency.Valute.HKD.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.DKK.Name, JSONConnect.DataCurrency.Valute.DKK.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.USD.Name, JSONConnect.DataCurrency.Valute.USD.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.EUR.Name, JSONConnect.DataCurrency.Valute.EUR.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.INR.Name, JSONConnect.DataCurrency.Valute.INR.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.KZT.Name, JSONConnect.DataCurrency.Valute.KZT.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.CAD.Name, JSONConnect.DataCurrency.Valute.CAD.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.KGS.Name, JSONConnect.DataCurrency.Valute.KGS.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.CNY.Name, JSONConnect.DataCurrency.Valute.CNY.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.MDL.Name, JSONConnect.DataCurrency.Valute.MDL.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.NOK.Name, JSONConnect.DataCurrency.Valute.NOK.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.PLN.Name, JSONConnect.DataCurrency.Valute.PLN.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.RON.Name, JSONConnect.DataCurrency.Valute.RON.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.XDR.Name, JSONConnect.DataCurrency.Valute.XDR.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.SGD.Name, JSONConnect.DataCurrency.Valute.SGD.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.TJS.Name, JSONConnect.DataCurrency.Valute.TJS.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.TRY.Name, JSONConnect.DataCurrency.Valute.TRY.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.TMT.Name, JSONConnect.DataCurrency.Valute.TMT.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.UZS.Name, JSONConnect.DataCurrency.Valute.UZS.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.UAH.Name, JSONConnect.DataCurrency.Valute.UAH.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.CZK.Name, JSONConnect.DataCurrency.Valute.CZK.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.SEK.Name, JSONConnect.DataCurrency.Valute.SEK.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.CHF.Name, JSONConnect.DataCurrency.Valute.CHF.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.ZAR.Name, JSONConnect.DataCurrency.Valute.ZAR.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.KRW.Name, JSONConnect.DataCurrency.Valute.KRW.CharCode);
            dataGridView.Rows.Add(JSONConnect.DataCurrency.Valute.JPY.Name, JSONConnect.DataCurrency.Valute.JPY.CharCode);
            this.Controls.Add(dataGridView);
            dataGridView.Rows[0].Cells[0].Selected = false;
            if (darkmode == false)
            {
                dataGridView.ForeColor = ColorTranslator.FromHtml("#33363B");
                dataGridView.GridColor = ColorTranslator.FromHtml("#33363B");
                dataGridView.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E0E6C8");
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#33363B");
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E0E6C8");
                dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#E0E6C8");
                dataGridView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#96998A");
            }
            else
            {
                dataGridView.ForeColor = ColorTranslator.FromHtml("#999795");
                dataGridView.GridColor = ColorTranslator.FromHtml("#0B0B17");
                dataGridView.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#333230");
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#999795");
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#333230");
                dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#333230");
                dataGridView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#333230");
            }
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (dataGridView.Rows[i].Cells[1].Value.ToString() == values)
                {
                    dataGridView.Rows[i].Cells[2].Value = "\u2713";
                    dataGridView.Rows[i].Cells[1].Selected = true;
                }    
            }
            dataGridView.CellClick += (object sender, DataGridViewCellEventArgs e) =>
            {
                if (first == true)
                {
                    Variables.value(dataGridView[1, dataGridView.CurrentCell.RowIndex].Value.ToString(), ref Nominal_1, ref Name_1, ref Value_1, ref Previous_1);
                    label_1.Text = CharCode_1 = dataGridView[1, dataGridView.CurrentCell.RowIndex].Value.ToString();
                    text_2.Text = Convert.ToString(Math.Round((Convert.ToDouble(text_1.Text) * (Value_1 / Nominal_1)) / (Value_2 / Nominal_2), 2));
                }
                else
                {
                    Variables.value(dataGridView[1, dataGridView.CurrentCell.RowIndex].Value.ToString(), ref Nominal_2, ref Name_2, ref Value_2, ref Previous_2);
                    label_2.Text = CharCode_2 = dataGridView[1, dataGridView.CurrentCell.RowIndex].Value.ToString();
                    text_1.Text = Convert.ToString(Math.Round((Convert.ToDouble(text_2.Text) * (Value_2 / Nominal_2)) / (Value_1 / Nominal_1), 2));
                }
                dataGridView.Dispose();
                screenloading("converter", null, false);
                course();
                tooltips(darkmode);
            };
        }

        private void picgithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/umanets-alexander/CurrencyConverter");
        }

        private void colormode(bool result)
        {
            if (result == false)
            {
                panelbottom.BackColor = panelcenter.BackColor = panelleft.BackColor = panelright.BackColor = paneltop.BackColor = this.BackColor = ColorTranslator.FromHtml("#DFE2E6");
                button_1.BackColor = button_2.BackColor = ColorTranslator.FromHtml("#E0E6C8");
                button_1.ForeColor = button_2.ForeColor = ColorTranslator.FromHtml("#33363B");
                label_1.ForeColor = label_2.ForeColor = ColorTranslator.FromHtml("#33363B");
                text_1.BackColor = text_2.BackColor = ColorTranslator.FromHtml("#E0E6C8");
                text_1.ForeColor = text_2.ForeColor = ColorTranslator.FromHtml("#33363B");
            }
            else
            {
                panelbottom.BackColor = panelcenter.BackColor = panelleft.BackColor = panelright.BackColor = paneltop.BackColor = this.BackColor = ColorTranslator.FromHtml("#333230");
                button_1.BackColor = button_2.BackColor = ColorTranslator.FromHtml("#0B0B17");
                button_1.ForeColor = button_2.ForeColor = ColorTranslator.FromHtml("#999795");
                label_1.ForeColor = label_2.ForeColor = ColorTranslator.FromHtml("#999795");
                text_1.BackColor = text_2.BackColor = ColorTranslator.FromHtml("#999795");
                text_1.ForeColor = text_2.ForeColor = ColorTranslator.FromHtml("#0B0B17");
            }


        }

        private void picmode_Click(object sender, EventArgs e)
        {
            if (darkmode == false)
            {
                darkmode = true;
                picmode.Image = Image.FromFile(Path.GetFullPath(@"icon\lightmode.png"));
            }
            else
            {
                darkmode = false;
                picmode.Image = Image.FromFile(Path.GetFullPath(@"icon\darkmode.png"));
            }
            colormode(darkmode);
            tooltips(darkmode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            screenconvert(false);
            screenloading("table", CharCode_1, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screenconvert(false);
            screenloading("table", CharCode_2, false);
        }

        private void text_1_TextChanged(object sender, EventArgs e)
        {
            text_2.Text = Convert.ToString(Math.Round((Convert.ToDouble(text_1.Text) * (Value_1 / Nominal_1)) / (Value_2 / Nominal_2), 2));
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
            course();
            tooltips(darkmode);
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

        private void text_2_TextChanged(object sender, EventArgs e)
        {
            text_1.Text = Convert.ToString(Math.Round((Convert.ToDouble(text_2.Text) * (Value_2 / Nominal_2)) / (Value_1 / Nominal_1), 2));
        }

        private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
    }
}
