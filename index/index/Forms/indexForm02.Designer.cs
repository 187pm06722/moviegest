﻿namespace index
{
    partial class indexForm02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indexForm02));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.LinkLabel();
            this.btnBrowseForMovies = new System.Windows.Forms.LinkLabel();
            this.btnYourFavorites = new System.Windows.Forms.LinkLabel();
            this.logoBox01 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox01)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnBrowseForMovies);
            this.panel1.Controls.Add(this.btnYourFavorites);
            this.panel1.Controls.Add(this.logoBox01);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 749);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.ActiveLinkColor = System.Drawing.Color.Red;
            this.btnExit.AllowDrop = true;
            this.btnExit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnExit.LinkColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(-1, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 84);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = true;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnBrowseForMovies
            // 
            this.btnBrowseForMovies.ActiveLinkColor = System.Drawing.Color.Red;
            this.btnBrowseForMovies.AllowDrop = true;
            this.btnBrowseForMovies.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseForMovies.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseForMovies.Image")));
            this.btnBrowseForMovies.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnBrowseForMovies.LinkColor = System.Drawing.Color.White;
            this.btnBrowseForMovies.Location = new System.Drawing.Point(1, 124);
            this.btnBrowseForMovies.Name = "btnBrowseForMovies";
            this.btnBrowseForMovies.Size = new System.Drawing.Size(197, 112);
            this.btnBrowseForMovies.TabIndex = 3;
            this.btnBrowseForMovies.TabStop = true;
            this.btnBrowseForMovies.Text = "Browse For Movies";
            this.btnBrowseForMovies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBrowseForMovies.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnBrowseForMovies_LinkClicked);
            // 
            // btnYourFavorites
            // 
            this.btnYourFavorites.ActiveLinkColor = System.Drawing.Color.Red;
            this.btnYourFavorites.AllowDrop = true;
            this.btnYourFavorites.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYourFavorites.Image = ((System.Drawing.Image)(resources.GetObject("btnYourFavorites.Image")));
            this.btnYourFavorites.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnYourFavorites.LinkColor = System.Drawing.Color.White;
            this.btnYourFavorites.Location = new System.Drawing.Point(3, 244);
            this.btnYourFavorites.Name = "btnYourFavorites";
            this.btnYourFavorites.Size = new System.Drawing.Size(197, 101);
            this.btnYourFavorites.TabIndex = 2;
            this.btnYourFavorites.TabStop = true;
            this.btnYourFavorites.Text = "Your Favorites";
            this.btnYourFavorites.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // logoBox01
            // 
            this.logoBox01.BackColor = System.Drawing.Color.Transparent;
            this.logoBox01.Image = ((System.Drawing.Image)(resources.GetObject("logoBox01.Image")));
            this.logoBox01.Location = new System.Drawing.Point(0, 0);
            this.logoBox01.Name = "logoBox01";
            this.logoBox01.Size = new System.Drawing.Size(199, 121);
            this.logoBox01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox01.TabIndex = 1;
            this.logoBox01.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 749);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.webBrowser1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(199, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1171, 749);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top rated movies from website";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(7, 38);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1161, 711);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri(resources.GetString("webBrowser1.Url"), System.UriKind.Absolute);
            // 
            // indexForm02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "indexForm02";
            this.Text = "Moviegest Index";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox01)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox logoBox01;
        private System.Windows.Forms.LinkLabel btnYourFavorites;
        private System.Windows.Forms.LinkLabel btnBrowseForMovies;
        private System.Windows.Forms.LinkLabel btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}