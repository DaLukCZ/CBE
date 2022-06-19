namespace Chcete_byt_EXPERTEM
{
    partial class Lose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lose));
            this.button_exit = new System.Windows.Forms.Button();
            this.button_newGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Menu = new System.Windows.Forms.Button();
            this.label_pocet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_exit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(500, 333);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(177, 104);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Ukončit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_Answer1_Click);
            // 
            // button_newGame
            // 
            this.button_newGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_newGame.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_newGame.ForeColor = System.Drawing.Color.White;
            this.button_newGame.Location = new System.Drawing.Point(65, 333);
            this.button_newGame.Name = "button_newGame";
            this.button_newGame.Size = new System.Drawing.Size(177, 104);
            this.button_newGame.TabIndex = 8;
            this.button_newGame.Text = "Nová hra";
            this.button_newGame.UseVisualStyleBackColor = false;
            this.button_newGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 59);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bohužel to bylo špatně.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(59, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(625, 86);
            this.label3.TabIndex = 12;
            this.label3.Text = ".";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Menu
            // 
            this.button_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button_Menu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Menu.ForeColor = System.Drawing.Color.White;
            this.button_Menu.Location = new System.Drawing.Point(285, 333);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(177, 104);
            this.button_Menu.TabIndex = 13;
            this.button_Menu.Text = "Menu";
            this.button_Menu.UseVisualStyleBackColor = false;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // label_pocet
            // 
            this.label_pocet.AutoSize = true;
            this.label_pocet.BackColor = System.Drawing.Color.Transparent;
            this.label_pocet.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_pocet.ForeColor = System.Drawing.Color.White;
            this.label_pocet.Location = new System.Drawing.Point(341, 241);
            this.label_pocet.Name = "label_pocet";
            this.label_pocet.Size = new System.Drawing.Size(86, 36);
            this.label_pocet.TabIndex = 14;
            this.label_pocet.Text = "9 / 10";
            this.label_pocet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Chcete_byt_EXPERTEM.Properties.Resources.backblue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 488);
            this.Controls.Add(this.label_pocet);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_newGame);
            this.Controls.Add(this.button_exit);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(590, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lose";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Lose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_newGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Label label_pocet;
    }
}