namespace Ekonomikare
{
    partial class Pritel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pritel));
            this.label_spravnaOdpoved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_spravnaOdpoved
            // 
            this.label_spravnaOdpoved.AutoSize = true;
            this.label_spravnaOdpoved.Location = new System.Drawing.Point(293, 209);
            this.label_spravnaOdpoved.Name = "label_spravnaOdpoved";
            this.label_spravnaOdpoved.Size = new System.Drawing.Size(123, 13);
            this.label_spravnaOdpoved.TabIndex = 0;
            this.label_spravnaOdpoved.Text = "label1_spravnaOdpoved";
            this.label_spravnaOdpoved.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pritel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_spravnaOdpoved);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pritel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pritel";
            this.Load += new System.EventHandler(this.Pritel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_spravnaOdpoved;
    }
}