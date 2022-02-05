
using System.Threading;

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
            this.button_Answer4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_otazka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Zkontroluj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_CallHelp = new System.Windows.Forms.Button();
            this.button_HelpAudiance = new System.Windows.Forms.Button();
            this.button_5050 = new System.Windows.Forms.Button();
            this.button_otazka = new System.Windows.Forms.Button();
            this.button_Answer3 = new System.Windows.Forms.Button();
            this.button_Answer2 = new System.Windows.Forms.Button();
            this.button_Answer1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // button_Answer4
            // 
            this.button_Answer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Answer4.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Answer4.ForeColor = System.Drawing.Color.White;
            this.button_Answer4.Location = new System.Drawing.Point(1001, 823);
            this.button_Answer4.Name = "button_Answer4";
            this.button_Answer4.Size = new System.Drawing.Size(291, 145);
            this.button_Answer4.TabIndex = 4;
            this.button_Answer4.Text = "Odpověd 4";
            this.button_Answer4.UseVisualStyleBackColor = false;
            this.button_Answer4.Click += new System.EventHandler(this.button_Answer4_Click);
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
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.label_otazka);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Zkontroluj);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.button_otazka);
            this.panel1.Controls.Add(this.button_Answer3);
            this.panel1.Controls.Add(this.button_Answer2);
            this.panel1.Controls.Add(this.button_Answer1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_Answer4);
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
            this.tableLayoutPanel1.Controls.Add(this.button_CallHelp, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_HelpAudiance, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_5050, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1555, 182);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 100);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // button_CallHelp
            // 
            this.button_CallHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_CallHelp.BackgroundImage = global::Ekonomikare.Properties.Resources.callFriend;
            this.button_CallHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_CallHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CallHelp.Location = new System.Drawing.Point(233, 3);
            this.button_CallHelp.Name = "button_CallHelp";
            this.button_CallHelp.Size = new System.Drawing.Size(110, 94);
            this.button_CallHelp.TabIndex = 2;
            this.button_CallHelp.UseVisualStyleBackColor = false;
            this.button_CallHelp.Click += new System.EventHandler(this.button_Call_Help_Click);
            // 
            // button_HelpAudiance
            // 
            this.button_HelpAudiance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_HelpAudiance.BackgroundImage = global::Ekonomikare.Properties.Resources.helpAudiance;
            this.button_HelpAudiance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_HelpAudiance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_HelpAudiance.Location = new System.Drawing.Point(118, 3);
            this.button_HelpAudiance.Name = "button_HelpAudiance";
            this.button_HelpAudiance.Size = new System.Drawing.Size(109, 94);
            this.button_HelpAudiance.TabIndex = 1;
            this.button_HelpAudiance.UseVisualStyleBackColor = false;
            this.button_HelpAudiance.Click += new System.EventHandler(this.button_Audiance_Help_Click);
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
            // button_Answer3
            // 
            this.button_Answer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Answer3.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Answer3.ForeColor = System.Drawing.Color.White;
            this.button_Answer3.Location = new System.Drawing.Point(628, 823);
            this.button_Answer3.Name = "button_Answer3";
            this.button_Answer3.Size = new System.Drawing.Size(291, 145);
            this.button_Answer3.TabIndex = 8;
            this.button_Answer3.Text = "Odpověd 3";
            this.button_Answer3.UseVisualStyleBackColor = false;
            this.button_Answer3.Click += new System.EventHandler(this.button_Answer3_Click);
            // 
            // button_Answer2
            // 
            this.button_Answer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Answer2.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Answer2.ForeColor = System.Drawing.Color.White;
            this.button_Answer2.Location = new System.Drawing.Point(1001, 641);
            this.button_Answer2.Name = "button_Answer2";
            this.button_Answer2.Size = new System.Drawing.Size(291, 145);
            this.button_Answer2.TabIndex = 7;
            this.button_Answer2.Text = "Odpověd 2";
            this.button_Answer2.UseVisualStyleBackColor = false;
            this.button_Answer2.Click += new System.EventHandler(this.button_Answer2_Click);
            // 
            // button_Answer1
            // 
            this.button_Answer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Answer1.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Answer1.ForeColor = System.Drawing.Color.White;
            this.button_Answer1.Location = new System.Drawing.Point(628, 641);
            this.button_Answer1.Name = "button_Answer1";
            this.button_Answer1.Size = new System.Drawing.Size(291, 145);
            this.button_Answer1.TabIndex = 6;
            this.button_Answer1.Text = "Odpověd 1";
            this.button_Answer1.UseVisualStyleBackColor = false;
            this.button_Answer1.Click += new System.EventHandler(this.button_Answer1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            Thread img = new Thread(() =>
            {
                this.BackgroundImage = global::Ekonomikare.Properties.Resources.background;
            });
            img.Start();
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Chcete být milionářem?";
            Thread thr = new Thread(() =>
            {
                this.Load += new System.EventHandler(this.Main_Load_1);
            });
            thr.Start();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_Answer4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Answer1;
        private System.Windows.Forms.Button button_Answer3;
        private System.Windows.Forms.Button button_Answer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_CallHelp;
        private System.Windows.Forms.Button button_HelpAudiance;
        private System.Windows.Forms.Button button_5050;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_otazka;
        private System.Windows.Forms.Button button_Zkontroluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_otazka;
        private System.Windows.Forms.Button button_exit;
    }
}

