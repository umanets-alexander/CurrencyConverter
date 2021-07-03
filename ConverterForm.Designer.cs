
namespace CurrencyConverter
{
    partial class ConverterForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picgithub = new System.Windows.Forms.PictureBox();
            this.picswap = new System.Windows.Forms.PictureBox();
            this.text_2 = new System.Windows.Forms.TextBox();
            this.label_2 = new System.Windows.Forms.Label();
            this.button_2 = new System.Windows.Forms.Button();
            this.picstatus_2 = new System.Windows.Forms.PictureBox();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.panelcenter = new System.Windows.Forms.Panel();
            this.text_1 = new System.Windows.Forms.TextBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.button_1 = new System.Windows.Forms.Button();
            this.picstatus_1 = new System.Windows.Forms.PictureBox();
            this.paneltop = new System.Windows.Forms.Panel();
            this.picmode = new System.Windows.Forms.PictureBox();
            this.panelright = new System.Windows.Forms.Panel();
            this.panelleft = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picgithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picswap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picstatus_2)).BeginInit();
            this.panelbottom.SuspendLayout();
            this.panelcenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picstatus_1)).BeginInit();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmode)).BeginInit();
            this.panelright.SuspendLayout();
            this.panelleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // picgithub
            // 
            this.picgithub.Location = new System.Drawing.Point(417, 1);
            this.picgithub.Name = "picgithub";
            this.picgithub.Size = new System.Drawing.Size(32, 32);
            this.picgithub.TabIndex = 0;
            this.picgithub.TabStop = false;
            this.picgithub.Click += new System.EventHandler(this.picgithub_Click);
            // 
            // picswap
            // 
            this.picswap.Location = new System.Drawing.Point(9, 54);
            this.picswap.Name = "picswap";
            this.picswap.Size = new System.Drawing.Size(32, 32);
            this.picswap.TabIndex = 1;
            this.picswap.TabStop = false;
            this.picswap.Click += new System.EventHandler(this.picswap_Click_1);
            // 
            // text_2
            // 
            this.text_2.Location = new System.Drawing.Point(7, 8);
            this.text_2.Name = "text_2";
            this.text_2.Size = new System.Drawing.Size(155, 26);
            this.text_2.TabIndex = 1;
            this.text_2.Text = "0";
            this.text_2.TextChanged += new System.EventHandler(this.text_2_TextChanged);
            this.text_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_2_KeyPress);
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_2.Location = new System.Drawing.Point(53, 99);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(90, 39);
            this.label_2.TabIndex = 2;
            this.label_2.Text = "USD";
            // 
            // button_2
            // 
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Location = new System.Drawing.Point(6, 155);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(187, 46);
            this.button_2.TabIndex = 3;
            this.button_2.Text = "Сменить валюту";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button2_Click);
            // 
            // picstatus_2
            // 
            this.picstatus_2.Location = new System.Drawing.Point(169, 10);
            this.picstatus_2.Name = "picstatus_2";
            this.picstatus_2.Size = new System.Drawing.Size(24, 24);
            this.picstatus_2.TabIndex = 4;
            this.picstatus_2.TabStop = false;
            // 
            // panelbottom
            // 
            this.panelbottom.Controls.Add(this.picgithub);
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 345);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(450, 34);
            this.panelbottom.TabIndex = 1;
            // 
            // panelcenter
            // 
            this.panelcenter.Controls.Add(this.picswap);
            this.panelcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcenter.Location = new System.Drawing.Point(200, 34);
            this.panelcenter.Name = "panelcenter";
            this.panelcenter.Size = new System.Drawing.Size(50, 311);
            this.panelcenter.TabIndex = 4;
            // 
            // text_1
            // 
            this.text_1.Location = new System.Drawing.Point(7, 8);
            this.text_1.Name = "text_1";
            this.text_1.Size = new System.Drawing.Size(155, 26);
            this.text_1.TabIndex = 0;
            this.text_1.Text = "0";
            this.text_1.TextChanged += new System.EventHandler(this.text_1_TextChanged);
            this.text_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_1_KeyPress);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_1.Location = new System.Drawing.Point(53, 99);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(90, 39);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "USD";
            // 
            // button_1
            // 
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Location = new System.Drawing.Point(6, 155);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(187, 46);
            this.button_1.TabIndex = 2;
            this.button_1.Text = "Сменить валюту";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picstatus_1
            // 
            this.picstatus_1.Location = new System.Drawing.Point(169, 10);
            this.picstatus_1.Name = "picstatus_1";
            this.picstatus_1.Size = new System.Drawing.Size(24, 24);
            this.picstatus_1.TabIndex = 3;
            this.picstatus_1.TabStop = false;
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.picmode);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(450, 34);
            this.paneltop.TabIndex = 0;
            // 
            // picmode
            // 
            this.picmode.Location = new System.Drawing.Point(417, 1);
            this.picmode.Name = "picmode";
            this.picmode.Size = new System.Drawing.Size(32, 32);
            this.picmode.TabIndex = 0;
            this.picmode.TabStop = false;
            this.picmode.Click += new System.EventHandler(this.picmode_Click);
            // 
            // panelright
            // 
            this.panelright.Controls.Add(this.picstatus_2);
            this.panelright.Controls.Add(this.button_2);
            this.panelright.Controls.Add(this.label_2);
            this.panelright.Controls.Add(this.text_2);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelright.Location = new System.Drawing.Point(250, 34);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(200, 311);
            this.panelright.TabIndex = 3;
            // 
            // panelleft
            // 
            this.panelleft.Controls.Add(this.picstatus_1);
            this.panelleft.Controls.Add(this.button_1);
            this.panelleft.Controls.Add(this.label_1);
            this.panelleft.Controls.Add(this.text_1);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 34);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(200, 311);
            this.panelleft.TabIndex = 2;
            // 
            // toolTip
            // 
            this.toolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip_Draw);
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 379);
            this.Controls.Add(this.panelcenter);
            this.Controls.Add(this.panelright);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.paneltop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConverterForm";
            this.Text = "Конвертер валют";
            ((System.ComponentModel.ISupportInitialize)(this.picgithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picswap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picstatus_2)).EndInit();
            this.panelbottom.ResumeLayout(false);
            this.panelcenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picstatus_1)).EndInit();
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picmode)).EndInit();
            this.panelright.ResumeLayout(false);
            this.panelright.PerformLayout();
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picgithub;
        private System.Windows.Forms.PictureBox picswap;
        private System.Windows.Forms.TextBox text_2;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.PictureBox picstatus_2;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Panel panelcenter;
        private System.Windows.Forms.TextBox text_1;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.PictureBox picstatus_1;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox picmode;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

