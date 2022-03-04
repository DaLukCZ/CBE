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
            this.checkBox5050 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxFriend = new System.Windows.Forms.CheckBox();
            this.checkBoxRada = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox5050
            // 
            this.checkBox5050.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.checkBox5050.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.checkBox5050.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox5050.Location = new System.Drawing.Point(142, 128);
            this.checkBox5050.Name = "checkBox5050";
            this.checkBox5050.Size = new System.Drawing.Size(263, 50);
            this.checkBox5050.TabIndex = 0;
            this.checkBox5050.Text = " - 50/50";
            this.checkBox5050.UseVisualStyleBackColor = false;
            this.checkBox5050.CheckedChanged += new System.EventHandler(this.checkBox5050_CheckedChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button1.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(180, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 102);
            this.button1.TabIndex = 17;
            this.button1.Text = "Zpět";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxFriend
            // 
            this.checkBoxFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.checkBoxFriend.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.checkBoxFriend.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxFriend.Location = new System.Drawing.Point(142, 261);
            this.checkBoxFriend.Name = "checkBoxFriend";
            this.checkBoxFriend.Size = new System.Drawing.Size(263, 50);
            this.checkBoxFriend.TabIndex = 18;
            this.checkBoxFriend.Text = " - Přítel na telefonu";
            this.checkBoxFriend.UseVisualStyleBackColor = false;
            this.checkBoxFriend.CheckedChanged += new System.EventHandler(this.checkBoxFriend_CheckedChanged);
            // 
            // checkBoxRada
            // 
            this.checkBoxRada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.checkBoxRada.Font = new System.Drawing.Font("Yu Gothic Medium", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.checkBoxRada.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxRada.Location = new System.Drawing.Point(142, 196);
            this.checkBoxRada.Name = "checkBoxRada";
            this.checkBoxRada.Size = new System.Drawing.Size(263, 50);
            this.checkBoxRada.TabIndex = 18;
            this.checkBoxRada.Text = " - Rada Publika";
            this.checkBoxRada.UseVisualStyleBackColor = false;
            this.checkBoxRada.CheckedChanged += new System.EventHandler(this.checkBox_Rada_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Ekonomikare.Properties.Resources.male3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 791);
            this.Controls.Add(this.checkBoxRada);
            this.Controls.Add(this.checkBoxFriend);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox5050);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chcete být Ekonomem?";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox5050;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxFriend;
        private System.Windows.Forms.CheckBox checkBoxRada;
    }
}