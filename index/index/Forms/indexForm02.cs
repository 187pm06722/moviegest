using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace index
{
    
    public partial class indexForm02 : Form
    {
        private moviesManagement Business;
        public indexForm02()
        {
            InitializeComponent();
            this.btnExit.Click += LlExit_Click;
            this.btnBrowseForMovies.Click += btnBrowseForMovies_Click;
        }

        void btnBrowseForMovies_Click(object sender, EventArgs e)
        {
            //var btnBrowseForMovies = new browseForm();
            //btnBrowseForMovies.ShowDialog();
        }

        void LlExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            try
            {
                Exit = MessageBox.Show("System warning! Do you want to exit. Confirm if you want to exit", "Exit form", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(Exit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("System error! Please check it again", ex);
            }
        }

        private void btnBrowseForMovies_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
