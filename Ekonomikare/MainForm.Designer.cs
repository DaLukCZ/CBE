
namespace Ekonomikare
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_menu = new System.Windows.Forms.Button();
            this.button_Odpoved4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_otazka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Zkontroluj = new System.Windows.Forms.Button();
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
            this.button_PritelTelefon = new System.Windows.Forms.Button();
            this.button_RadaPublika = new System.Windows.Forms.Button();
            this.button_5050 = new System.Windows.Forms.Button();
            this.button_otazka = new System.Windows.Forms.Button();
            this.button_Odpoved3 = new System.Windows.Forms.Button();
            this.button_Odpoved2 = new System.Windows.Forms.Button();
            this.button_Odpoved1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_graf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_menu
            // 
            this.button_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_menu.BackgroundImage = global::Ekonomikare.Properties.Resources.MENU;
            this.button_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_menu.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_menu.Location = new System.Drawing.Point(1619, 36);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(219, 82);
            this.button_menu.TabIndex = 0;
            this.button_menu.UseVisualStyleBackColor = false;
            this.button_menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // button_Odpoved4
            // 
            this.button_Odpoved4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Odpoved4.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Odpoved4.ForeColor = System.Drawing.Color.White;
            this.button_Odpoved4.Location = new System.Drawing.Point(1001, 823);
            this.button_Odpoved4.Name = "button_Odpoved4";
            this.button_Odpoved4.Size = new System.Drawing.Size(291, 145);
            this.button_Odpoved4.TabIndex = 4;
            this.button_Odpoved4.Text = "Odpověd 4";
            this.button_Odpoved4.UseVisualStyleBackColor = false;
            this.button_Odpoved4.Click += new System.EventHandler(this.button_Answer4_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Ekonomikare.Properties.Resources.step0;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(1555, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 536);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.label_otazka);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Zkontroluj);
            this.panel1.Controls.Add(this.panel_graf);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.button_otazka);
            this.panel1.Controls.Add(this.button_Odpoved3);
            this.panel1.Controls.Add(this.button_Odpoved2);
            this.panel1.Controls.Add(this.button_Odpoved1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_Odpoved4);
            this.panel1.Controls.Add(this.button_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 1041);
            this.panel1.TabIndex = 0;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_exit.BackgroundImage = global::Ekonomikare.Properties.Resources.exit;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.Location = new System.Drawing.Point(82, 36);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(219, 82);
            this.button_exit.TabIndex = 0;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_otazka
            // 
            this.label_otazka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label_otazka.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_otazka.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_otazka.ForeColor = System.Drawing.Color.White;
            this.label_otazka.Location = new System.Drawing.Point(406, 462);
            this.label_otazka.Name = "label_otazka";
            this.label_otazka.Size = new System.Drawing.Size(1102, 122);
            this.label_otazka.TabIndex = 15;
            this.label_otazka.Text = "Otazka";
            this.label_otazka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // button_Zkontroluj
            // 
            this.button_Zkontroluj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Zkontroluj.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Zkontroluj.ForeColor = System.Drawing.Color.White;
            this.button_Zkontroluj.Location = new System.Drawing.Point(382, 759);
            this.button_Zkontroluj.Name = "button_Zkontroluj";
            this.button_Zkontroluj.Size = new System.Drawing.Size(210, 93);
            this.button_Zkontroluj.TabIndex = 13;
            this.button_Zkontroluj.Text = "Kontrola";
            this.button_Zkontroluj.UseVisualStyleBackColor = false;
            this.button_Zkontroluj.Click += new System.EventHandler(this.button_Check_Click);
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
            this.panel_graf.Location = new System.Drawing.Point(1172, 36);
            this.panel_graf.Name = "panel_graf";
            this.panel_graf.Size = new System.Drawing.Size(350, 350);
            this.panel_graf.TabIndex = 12;
            this.panel_graf.Visible = false;
            // 
            // label_Od4
            // 
            this.label_Od4.AutoSize = true;
            this.label_Od4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label_Od4.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Od4.ForeColor = System.Drawing.Color.White;
            this.label_Od4.Location = new System.Drawing.Point(227, 203);
            this.label_Od4.Name = "label_Od4";
            this.label_Od4.Size = new System.Drawing.Size(0, 26);
            this.label_Od4.TabIndex = 13;
            // 
            // label_Od3
            // 
            this.label_Od3.AutoSize = true;
            this.label_Od3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label_Od3.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Od3.ForeColor = System.Drawing.Color.White;
            this.label_Od3.Location = new System.Drawing.Point(227, 144);
            this.label_Od3.Name = "label_Od3";
            this.label_Od3.Size = new System.Drawing.Size(0, 26);
            this.label_Od3.TabIndex = 12;
            // 
            // label_Od2
            // 
            this.label_Od2.AutoSize = true;
            this.label_Od2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label_Od2.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Od2.ForeColor = System.Drawing.Color.White;
            this.label_Od2.Location = new System.Drawing.Point(227, 90);
            this.label_Od2.Name = "label_Od2";
            this.label_Od2.Size = new System.Drawing.Size(0, 26);
            this.label_Od2.TabIndex = 11;
            // 
            // label_Od1
            // 
            this.label_Od1.AutoSize = true;
            this.label_Od1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label_Od1.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Od1.ForeColor = System.Drawing.Color.White;
            this.label_Od1.Location = new System.Drawing.Point(227, 36);
            this.label_Od1.Name = "label_Od1";
            this.label_Od1.Size = new System.Drawing.Size(0, 26);
            this.label_Od1.TabIndex = 10;
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_close.Location = new System.Drawing.Point(196, 276);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(140, 53);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "Zavřit";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_Graph_Close_Click);
            // 
            // button_ask
            // 
            this.button_ask.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_ask.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ask.Location = new System.Drawing.Point(22, 275);
            this.button_ask.Name = "button_ask";
            this.button_ask.Size = new System.Drawing.Size(140, 54);
            this.button_ask.TabIndex = 8;
            this.button_ask.Text = "Hlasovat";
            this.button_ask.UseVisualStyleBackColor = true;
            this.button_ask.Click += new System.EventHandler(this.button_Ask_Click);
            // 
            // label_D
            // 
            this.label_D.AutoSize = true;
            this.label_D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label_D.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_D.ForeColor = System.Drawing.Color.White;
            this.label_D.Location = new System.Drawing.Point(18, 203);
            this.label_D.Name = "label_D";
            this.label_D.Size = new System.Drawing.Size(27, 26);
            this.label_D.TabIndex = 7;
            this.label_D.Text = "D";
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label_C.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_C.ForeColor = System.Drawing.Color.White;
            this.label_C.Location = new System.Drawing.Point(17, 143);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(26, 26);
            this.label_C.TabIndex = 6;
            this.label_C.Text = "C";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label_B.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_B.ForeColor = System.Drawing.Color.White;
            this.label_B.Location = new System.Drawing.Point(18, 90);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(26, 26);
            this.label_B.TabIndex = 5;
            this.label_B.Text = "B";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label_A.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_A.ForeColor = System.Drawing.Color.White;
            this.label_A.Location = new System.Drawing.Point(18, 36);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(26, 26);
            this.label_A.TabIndex = 4;
            this.label_A.Text = "A";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(50, 203);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(174, 23);
            this.progressBar4.TabIndex = 3;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(50, 146);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(175, 23);
            this.progressBar3.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(50, 90);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(175, 23);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(175, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Ekonomikare.Properties.Resources.Ekonomi;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(784, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button_PritelTelefon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_RadaPublika, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_5050, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1555, 182);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 100);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // button_PritelTelefon
            // 
            this.button_PritelTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_PritelTelefon.BackgroundImage = global::Ekonomikare.Properties.Resources.callFriend;
            this.button_PritelTelefon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_PritelTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PritelTelefon.Location = new System.Drawing.Point(233, 3);
            this.button_PritelTelefon.Name = "button_PritelTelefon";
            this.button_PritelTelefon.Size = new System.Drawing.Size(110, 94);
            this.button_PritelTelefon.TabIndex = 2;
            this.button_PritelTelefon.UseVisualStyleBackColor = false;
            this.button_PritelTelefon.Click += new System.EventHandler(this.button_Call_Help_Click);
            // 
            // button_RadaPublika
            // 
            this.button_RadaPublika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_RadaPublika.BackgroundImage = global::Ekonomikare.Properties.Resources.helpAudiance;
            this.button_RadaPublika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_RadaPublika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_RadaPublika.Location = new System.Drawing.Point(118, 3);
            this.button_RadaPublika.Name = "button_RadaPublika";
            this.button_RadaPublika.Size = new System.Drawing.Size(109, 94);
            this.button_RadaPublika.TabIndex = 1;
            this.button_RadaPublika.UseVisualStyleBackColor = false;
            this.button_RadaPublika.Click += new System.EventHandler(this.button_Audiance_Help_Click);
            // 
            // button_5050
            // 
            this.button_5050.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_5050.BackgroundImage = global::Ekonomikare.Properties.Resources._5050;
            this.button_5050.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_5050.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_5050.Location = new System.Drawing.Point(3, 3);
            this.button_5050.Name = "button_5050";
            this.button_5050.Size = new System.Drawing.Size(109, 94);
            this.button_5050.TabIndex = 0;
            this.button_5050.UseVisualStyleBackColor = false;
            this.button_5050.Click += new System.EventHandler(this.button_5050_Click);
            // 
            // button_otazka
            // 
            this.button_otazka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_otazka.Enabled = false;
            this.button_otazka.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_otazka.ForeColor = System.Drawing.Color.White;
            this.button_otazka.Location = new System.Drawing.Point(396, 448);
            this.button_otazka.Name = "button_otazka";
            this.button_otazka.Size = new System.Drawing.Size(1128, 145);
            this.button_otazka.TabIndex = 9;
            this.button_otazka.UseVisualStyleBackColor = false;
            // 
            // button_Odpoved3
            // 
            this.button_Odpoved3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Odpoved3.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Odpoved3.ForeColor = System.Drawing.Color.White;
            this.button_Odpoved3.Location = new System.Drawing.Point(628, 823);
            this.button_Odpoved3.Name = "button_Odpoved3";
            this.button_Odpoved3.Size = new System.Drawing.Size(291, 145);
            this.button_Odpoved3.TabIndex = 8;
            this.button_Odpoved3.Text = "Odpověd 3";
            this.button_Odpoved3.UseVisualStyleBackColor = false;
            this.button_Odpoved3.Click += new System.EventHandler(this.button_Answer3_Click);
            // 
            // button_Odpoved2
            // 
            this.button_Odpoved2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Odpoved2.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Odpoved2.ForeColor = System.Drawing.Color.White;
            this.button_Odpoved2.Location = new System.Drawing.Point(1001, 641);
            this.button_Odpoved2.Name = "button_Odpoved2";
            this.button_Odpoved2.Size = new System.Drawing.Size(291, 145);
            this.button_Odpoved2.TabIndex = 7;
            this.button_Odpoved2.Text = "Odpověd 2";
            this.button_Odpoved2.UseVisualStyleBackColor = false;
            this.button_Odpoved2.Click += new System.EventHandler(this.button_Answer2_Click);
            // 
            // button_Odpoved1
            // 
            this.button_Odpoved1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Odpoved1.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Odpoved1.ForeColor = System.Drawing.Color.White;
            this.button_Odpoved1.Location = new System.Drawing.Point(628, 641);
            this.button_Odpoved1.Name = "button_Odpoved1";
            this.button_Odpoved1.Size = new System.Drawing.Size(291, 145);
            this.button_Odpoved1.TabIndex = 6;
            this.button_Odpoved1.Text = "Odpověd 1";
            this.button_Odpoved1.UseVisualStyleBackColor = false;
            this.button_Odpoved1.Click += new System.EventHandler(this.button_Answer1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Ekonomikare.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chcete být milionářem?";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_graf.ResumeLayout(false);
            this.panel_graf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_Odpoved4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Odpoved1;
        private System.Windows.Forms.Button button_Odpoved3;
        private System.Windows.Forms.Button button_Odpoved2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_PritelTelefon;
        private System.Windows.Forms.Button button_RadaPublika;
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
        private System.Windows.Forms.Button button_Zkontroluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_otazka;
        private System.Windows.Forms.Button button_exit;
    }
}

