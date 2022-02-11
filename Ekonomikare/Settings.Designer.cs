namespace Ekonomikare
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.button_Menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.BackgroundImage = global::Ekonomikare.Properties.Resources.Ekonomi;
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logo.Location = new System.Drawing.Point(181, 87);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(419, 331);
            this.pictureBox_logo.TabIndex = 13;
            this.pictureBox_logo.TabStop = false;
            // 
            // button_Menu
            // 
            this.button_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Menu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Menu.ForeColor = System.Drawing.Color.White;
            this.button_Menu.Location = new System.Drawing.Point(276, 801);
            this.button_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(236, 128);
            this.button_Menu.TabIndex = 14;
            this.button_Menu.Text = "Zpět";
            this.button_Menu.UseVisualStyleBackColor = false;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 73);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hudba";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Ekonomikare.Properties.Resources.sound;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(412, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 107);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Ekonomikare.Properties.Resources.male3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 974);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.pictureBox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chcete být ekonomikářem?";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}