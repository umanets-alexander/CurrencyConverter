
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.picmode = new System.Windows.Forms.PictureBox();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.picgithub = new System.Windows.Forms.PictureBox();
            this.panelleft = new System.Windows.Forms.Panel();
            this.picstatus_1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelright = new System.Windows.Forms.Panel();
            this.picstatus_2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelcenter = new System.Windows.Forms.Panel();
            this.picswap = new System.Windows.Forms.PictureBox();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmode)).BeginInit();
            this.panelbottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picgithub)).BeginInit();
            this.panelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picstatus_1)).BeginInit();
            this.panelright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picstatus_2)).BeginInit();
            this.panelcenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picswap)).BeginInit();
            this.SuspendLayout();
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
            this.picmode.Location = new System.Drawing.Point(369, 1);
            this.picmode.Name = "picmode";
            this.picmode.Size = new System.Drawing.Size(80, 32);
            this.picmode.TabIndex = 0;
            this.picmode.TabStop = false;
            this.picmode.Click += new System.EventHandler(this.picmode_Click);
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
            // picgithub
            // 
            this.picgithub.Location = new System.Drawing.Point(417, 1);
            this.picgithub.Name = "picgithub";
            this.picgithub.Size = new System.Drawing.Size(32, 32);
            this.picgithub.TabIndex = 0;
            this.picgithub.TabStop = false;
            this.picgithub.Click += new System.EventHandler(this.picgithub_Click);
            // 
            // panelleft
            // 
            this.panelleft.Controls.Add(this.picstatus_1);
            this.panelleft.Controls.Add(this.button1);
            this.panelleft.Controls.Add(this.label1);
            this.panelleft.Controls.Add(this.textBox1);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 34);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(200, 311);
            this.panelleft.TabIndex = 2;
            // 
            // picstatus_1
            // 
            this.picstatus_1.Location = new System.Drawing.Point(169, 10);
            this.picstatus_1.Name = "picstatus_1";
            this.picstatus_1.Size = new System.Drawing.Size(24, 24);
            this.picstatus_1.TabIndex = 3;
            this.picstatus_1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сменить валюту";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "USD";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 0;
            // 
            // panelright
            // 
            this.panelright.Controls.Add(this.picstatus_2);
            this.panelright.Controls.Add(this.button2);
            this.panelright.Controls.Add(this.label2);
            this.panelright.Controls.Add(this.textBox2);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelright.Location = new System.Drawing.Point(250, 34);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(200, 311);
            this.panelright.TabIndex = 3;
            // 
            // picstatus_2
            // 
            this.picstatus_2.Location = new System.Drawing.Point(169, 10);
            this.picstatus_2.Name = "picstatus_2";
            this.picstatus_2.Size = new System.Drawing.Size(24, 24);
            this.picstatus_2.TabIndex = 4;
            this.picstatus_2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сменить валюту";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "USD";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 26);
            this.textBox2.TabIndex = 1;
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
            // picswap
            // 
            this.picswap.Location = new System.Drawing.Point(9, 54);
            this.picswap.Name = "picswap";
            this.picswap.Size = new System.Drawing.Size(32, 32);
            this.picswap.TabIndex = 1;
            this.picswap.TabStop = false;
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
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picmode)).EndInit();
            this.panelbottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picgithub)).EndInit();
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picstatus_1)).EndInit();
            this.panelright.ResumeLayout(false);
            this.panelright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picstatus_2)).EndInit();
            this.panelcenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picswap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox picmode;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.PictureBox picgithub;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.PictureBox picstatus_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.PictureBox picstatus_2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panelcenter;
        private System.Windows.Forms.PictureBox picswap;
    }
}

