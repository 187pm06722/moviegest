using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace index.Forms
{
    public partial class UpdateMovieForm : Form
    {
        private int movieId;
        private FavoriteMoviesManagement Business;
        public UpdateMovieForm(int id)
        {
            InitializeComponent();
            this.movieId = id;
            this.Business = new FavoriteMoviesManagement();
            this.btnUpdate.Click += btnUpdate_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.Load += UpdateMovieForm_Load;
        }

        void UpdateMovieForm_Load(object sender, EventArgs e)
        {
            this.txtId.Text = movieId.ToString();
           //b this.txtBudget = 
            
            //throw new NotImplementedException();
        }

        void btnUpdate_Click(object sender, EventArgs e)
        {
            
            
            
            //throw new NotImplementedException();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Cancel;
            try
            {
                Cancel = MessageBox.Show("System warning! The process is being performed, are you sure want to cancel? Confirm if you want to cancel", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Cancel == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("System error! Please check it again", ex);
            }
        }
    }
}
