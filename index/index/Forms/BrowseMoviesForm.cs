using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Data.ProviderBase;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;

namespace index.Forms
{
    public partial class BrowseMoviesForm : Form
    {
        private moviesManagement Business;
        private string MovieTitle;
        SqlConnection con;
        public BrowseMoviesForm()
        {
            InitializeComponent();
            this.Business = new moviesManagement();
            this.MovieTitle = this.txtSearch.Text;
            this.Load +=BrowseMoviesForm_Load;
            this.btnAddNewMovie.Click += BtnAddNewMovie_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.btnAddToFavorite.Click += BtnAddToFavorite_Click;
            this.btnSearch.Click += btnSearch_Click;
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            ViewAMovies();            
            //throw new NotImplementedException();
        }

        private void ViewAMovies()
        {
            var db = new moviegestDBEntities1();

            //this.grdDB.DataSource = db.movie_dataset_fixed.SqlQuery("Select * from movie_dataset_fixed where title like (" + this.txtSearch.Text + ")");
            //this.grdDB.DataSource = db.movie_dataset_fixed.Where(p => p.title.Equals(this.txtSearch.Text)).ToList();
            //string sqlSELECT = "SELECT * FROM movie_dataset_fixed where title like ("+this.txtSearch.Text+")";
            string sqlSELECT = "SELECT * FROM movie_dataset_fixed where title like ('avatar')";
            SqlCommand cmd = new SqlCommand(sqlSELECT,con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            grdDB.DataSource = dt;



        }
       
        private void BtnAddNewMovie_Click(object sender, EventArgs e)
        {
            var btnAddNewMovie = new AddNewMoviesForm();
            btnAddNewMovie.ShowDialog();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel successfully.", "Cancel Form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }

        private void BtnAddToFavorite_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void BrowseMoviesForm_Load(object sender, EventArgs e)
        {
            //this.ViewAllMovies();
            //this.LoadAllMovies();
            string conString = ConfigurationManager.ConnectionStrings["moviegest"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            ViewAMovies();
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //do nothing
        }

        private void BrowseMoviesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

    }
}
