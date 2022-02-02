
namespace Ekonomikare
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button_exit = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_exit.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(184, 529);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(225, 102);
            this.button_exit.TabIndex = 14;
            this.button_exit.Text = "Ukončit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_start
            // 
            this.button_start.AutoSize = true;
            this.button_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_start.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.Color.White;
            this.button_start.Location = new System.Drawing.Point(184, 385);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(225, 102);
            this.button_start.TabIndex = 15;
            this.button_start.Text = "Začít hru";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.BackgroundImage = global::Ekonomikare.Properties.Resources.Ekonomi;
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logo.Location = new System.Drawing.Point(141, 71);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(314, 269);
            this.pictureBox_logo.TabIndex = 12;
            this.pictureBox_logo.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Ekonomikare.Properties.Resources.male3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 787);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.pictureBox_logo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(613, 830);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(613, 830);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chcete být ekonomikářem?";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.PictureBox pictureBox_logo;
    }
}