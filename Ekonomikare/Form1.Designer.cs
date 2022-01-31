
namespace Ekonomikare
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_exit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_graf = new System.Windows.Forms.Panel();
            this.label_Od4 = new System.Windows.Forms.Label();
            this.label_Od3 = new System.Windows.Forms.Label();
            this.label_Od2 = new System.Windows.Forms.Label();
            this.label_Od1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_ask = new System.Windows.Forms.Button();
            this.label_D = new System.Windows.Forms.Label();
            this.label_C = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button_5050 = new System.Windows.Forms.Button();
            this.button_otazka = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_graf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_exit.BackgroundImage = global::Ekonomikare.Properties.Resources.exit;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.Location = new System.Drawing.Point(2153, 44);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(308, 124);
            this.button_exit.TabIndex = 0;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1335, 1013);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(388, 178);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(2073, 368);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 660);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Ekonomikare.Properties.Resources.background_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel_graf);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.button_otazka);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2404, 1281);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_graf
            // 
            this.panel_graf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_graf.Controls.Add(this.label_Od4);
            this.panel_graf.Controls.Add(this.label_Od3);
            this.panel_graf.Controls.Add(this.label_Od2);
            this.panel_graf.Controls.Add(this.label_Od1);
            this.panel_graf.Controls.Add(this.button_close);
            this.panel_graf.Controls.Add(this.button_ask);
            this.panel_graf.Controls.Add(this.label_D);
            this.panel_graf.Controls.Add(this.label_C);
            this.panel_graf.Controls.Add(this.label_B);
            this.panel_graf.Controls.Add(this.label_A);
            this.panel_graf.Controls.Add(this.progressBar4);
            this.panel_graf.Controls.Add(this.progressBar3);
            this.panel_graf.Controls.Add(this.progressBar2);
            this.panel_graf.Controls.Add(this.progressBar1);
            this.panel_graf.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel_graf.Location = new System.Drawing.Point(1584, 44);
            this.panel_graf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_graf.Name = "panel_graf";
            this.panel_graf.Size = new System.Drawing.Size(469, 442);
            this.panel_graf.TabIndex = 12;
            this.panel_graf.Visible = false;
            // 
            // label_Od4
            // 
            this.label_Od4.AutoSize = true;
            this.label_Od4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Od4.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Od4.ForeColor = System.Drawing.Color.White;
            this.label_Od4.Location = new System.Drawing.Point(303, 250);
            this.label_Od4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Od4.Name = "label_Od4";
            this.label_Od4.Size = new System.Drawing.Size(135, 32);
            this.label_Od4.TabIndex = 13;
            this.label_Od4.Text = "Odpoved4";
            // 
            // label_Od3
            // 
            this.label_Od3.AutoSize = true;
            this.label_Od3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Od3.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Od3.ForeColor = System.Drawing.Color.White;
            this.label_Od3.Location = new System.Drawing.Point(303, 177);
            this.label_Od3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Od3.Name = "label_Od3";
            this.label_Od3.Size = new System.Drawing.Size(135, 32);
            this.label_Od3.TabIndex = 12;
            this.label_Od3.Text = "Odpoved3";
            // 
            // label_Od2
            // 
            this.label_Od2.AutoSize = true;
            this.label_Od2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Od2.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Od2.ForeColor = System.Drawing.Color.White;
            this.label_Od2.Location = new System.Drawing.Point(303, 111);
            this.label_Od2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Od2.Name = "label_Od2";
            this.label_Od2.Size = new System.Drawing.Size(135, 32);
            this.label_Od2.TabIndex = 11;
            this.label_Od2.Text = "Odpoved2";
            // 
            // label_Od1
            // 
            this.label_Od1.AutoSize = true;
            this.label_Od1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Od1.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Od1.ForeColor = System.Drawing.Color.White;
            this.label_Od1.Location = new System.Drawing.Point(303, 44);
            this.label_Od1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Od1.Name = "label_Od1";
            this.label_Od1.Size = new System.Drawing.Size(135, 32);
            this.label_Od1.TabIndex = 10;
            this.label_Od1.Text = "Odpoved1";
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_close.Location = new System.Drawing.Point(261, 340);
            this.button_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(187, 65);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "Zavřit";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_ask
            // 
            this.button_ask.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_ask.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ask.Location = new System.Drawing.Point(29, 338);
            this.button_ask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ask.Name = "button_ask";
            this.button_ask.Size = new System.Drawing.Size(187, 66);
            this.button_ask.TabIndex = 8;
            this.button_ask.Text = "Hlasovat";
            this.button_ask.UseVisualStyleBackColor = true;
            this.button_ask.Click += new System.EventHandler(this.button_ask_Click);
            // 
            // label_D
            // 
            this.label_D.AutoSize = true;
            this.label_D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_D.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_D.ForeColor = System.Drawing.Color.White;
            this.label_D.Location = new System.Drawing.Point(24, 250);
            this.label_D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_D.Name = "label_D";
            this.label_D.Size = new System.Drawing.Size(33, 32);
            this.label_D.TabIndex = 7;
            this.label_D.Text = "D";
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_C.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_C.ForeColor = System.Drawing.Color.White;
            this.label_C.Location = new System.Drawing.Point(23, 176);
            this.label_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(32, 32);
            this.label_C.TabIndex = 6;
            this.label_C.Text = "C";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_B.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_B.ForeColor = System.Drawing.Color.White;
            this.label_B.Location = new System.Drawing.Point(24, 111);
            this.label_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(32, 32);
            this.label_B.TabIndex = 5;
            this.label_B.Text = "B";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_A.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_A.ForeColor = System.Drawing.Color.White;
            this.label_A.Location = new System.Drawing.Point(24, 44);
            this.label_A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(31, 32);
            this.label_A.TabIndex = 4;
            this.label_A.Text = "A";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(67, 250);
            this.progressBar4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(232, 28);
            this.progressBar4.TabIndex = 3;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(67, 180);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(233, 28);
            this.progressBar3.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(67, 111);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(233, 28);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(67, 43);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Ekonomikare.Properties.Resources.Ekonomi;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1011, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 442);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_5050, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2073, 224);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 123);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.BackgroundImage = global::Ekonomikare.Properties.Resources.pritel;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(310, 4);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 115);
            this.button8.TabIndex = 2;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.BackgroundImage = global::Ekonomikare.Properties.Resources.radaPubl;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(157, 4);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 115);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button_5050
            // 
            this.button_5050.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_5050.BackgroundImage = global::Ekonomikare.Properties.Resources._5050;
            this.button_5050.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_5050.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_5050.Location = new System.Drawing.Point(4, 4);
            this.button_5050.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_5050.Name = "button_5050";
            this.button_5050.Size = new System.Drawing.Size(145, 115);
            this.button_5050.TabIndex = 0;
            this.button_5050.UseVisualStyleBackColor = false;
            this.button_5050.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_otazka
            // 
            this.button_otazka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_otazka.Enabled = false;
            this.button_otazka.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_otazka.ForeColor = System.Drawing.Color.White;
            this.button_otazka.Location = new System.Drawing.Point(528, 551);
            this.button_otazka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_otazka.Name = "button_otazka";
            this.button_otazka.Size = new System.Drawing.Size(1504, 178);
            this.button_otazka.TabIndex = 9;
            this.button_otazka.Text = "button5";
            this.button_otazka.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(837, 1013);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(388, 178);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1335, 789);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 178);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(837, 789);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(388, 178);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2404, 1281);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel_graf.ResumeLayout(false);
            this.panel_graf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button_5050;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_graf;
        private System.Windows.Forms.Label label_Od4;
        private System.Windows.Forms.Label label_Od3;
        private System.Windows.Forms.Label label_Od2;
        private System.Windows.Forms.Label label_Od1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_D;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_otazka;
        private System.Windows.Forms.Button button_ask;
    }
}

