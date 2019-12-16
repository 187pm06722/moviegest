namespace index.Forms
{
    partial class BrowseMoviesForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grdDB = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddToFavorite = new System.Windows.Forms.ToolStripMenuItem();
            this.clearResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdDB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(15, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 26);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(93, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(616, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grdDB
            // 
            this.grdDB.AllowUserToAddRows = false;
            this.grdDB.AllowUserToDeleteRows = false;
            this.grdDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDB.Location = new System.Drawing.Point(12, 91);
            this.grdDB.Name = "grdDB";
            this.grdDB.ReadOnly = true;
            this.grdDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDB.Size = new System.Drawing.Size(982, 298);
            this.grdDB.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddToFavorite,
            this.clearResultsToolStripMenuItem,
            this.btnSave,
            this.deleteARecordToolStripMenuItem,
            this.addNewMovieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 20);
            this.btnSave.Text = "Save Results To File";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnAddToFavorite
            // 
            this.btnAddToFavorite.Name = "btnAddToFavorite";
            this.btnAddToFavorite.Size = new System.Drawing.Size(128, 20);
            this.btnAddToFavorite.Text = "Add To Your Favorite";
            // 
            // clearResultsToolStripMenuItem
            // 
            this.clearResultsToolStripMenuItem.Name = "clearResultsToolStripMenuItem";
            this.clearResultsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.clearResultsToolStripMenuItem.Text = "Clear Results";
            this.clearResultsToolStripMenuItem.Click += new System.EventHandler(this.clearResultsToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search Result Table";
            // 
            // deleteARecordToolStripMenuItem
            // 
            this.deleteARecordToolStripMenuItem.Name = "deleteARecordToolStripMenuItem";
            this.deleteARecordToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.deleteARecordToolStripMenuItem.Text = "Delete A Record";
            this.deleteARecordToolStripMenuItem.Click += new System.EventHandler(this.deleteARecordToolStripMenuItem_Click);
            // 
            // addNewMovieToolStripMenuItem
            // 
            this.addNewMovieToolStripMenuItem.Name = "addNewMovieToolStripMenuItem";
            this.addNewMovieToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.addNewMovieToolStripMenuItem.Text = "Add New Movie";
            this.addNewMovieToolStripMenuItem.Click += new System.EventHandler(this.addNewMovieToolStripMenuItem_Click);
            // 
            // BrowseMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1006, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdDB);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BrowseMoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse Movies from Local Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrowseMoviesForm_FormClosing);
            this.Load += new System.EventHandler(this.BrowseMoviesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView grdDB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnAddToFavorite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem clearResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMovieToolStripMenuItem;
    }
}