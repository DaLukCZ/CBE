
namespace Ekonomikare
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.button_Settings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.AutoSize = true;
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Exit.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(180, 650);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(225, 102);
            this.button_Exit.TabIndex = 14;
            this.button_Exit.Text = "Ukončit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Start
            // 
            this.button_Start.AutoSize = true;
            this.button_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Start.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.ForeColor = System.Drawing.Color.White;
            this.button_Start.Location = new System.Drawing.Point(180, 390);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(225, 102);
            this.button_Start.TabIndex = 15;
            this.button_Start.Text = "Začít hru";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.BackgroundImage = global::Ekonomikare.Properties.Resources.Ekonomi;
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logo.Location = new System.Drawing.Point(136, 71);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(314, 269);
            this.pictureBox_logo.TabIndex = 12;
            this.pictureBox_logo.TabStop = false;
            // 
            // button_Settings
            // 
            this.button_Settings.AutoSize = true;
            this.button_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Settings.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Settings.ForeColor = System.Drawing.Color.White;
            this.button_Settings.Location = new System.Drawing.Point(180, 520);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(225, 102);
            this.button_Settings.TabIndex = 16;
            this.button_Settings.Text = "Nastavení";
            this.button_Settings.UseVisualStyleBackColor = false;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Ekonomikare.Properties.Resources.male3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 791);
            this.Controls.Add(this.button_Settings);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.pictureBox_logo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 830);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 830);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chcete být ekonomikářem?";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Button button_Settings;
    }
}