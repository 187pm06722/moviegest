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
        //SqlConnection connection = new;

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        SqlCommand command;
        string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\augus\OneDrive\Documents\moviegestDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
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
            this.ViewAMovies();            
            //throw new NotImplementedException();
        }

        private void ViewAMovies()
        {
            var db = new moviegestDBEntities1();

            //this.grdDB.DataSource = db.movie_dataset_fixed.SqlQuery("Select * from movie_dataset_fixed where title like (" + this.txtSearch.Text + ")");
            //this.grdDB.DataSource = db.movie_dataset_fixed.Where(p => p.title.Equals(this.txtSearch.Text)).ToList();
            //string sqlSELECT = "SELECT * FROM movie_dataset_fixed where title like ("+this.txtSearch.Text+")";
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM movie_dataset_fixed where title like ('%"+this.txtSearch.Text+"%')";
            adapter.SelectCommand = command;
            //table.Clear();
            adapter.Fill(table);
            grdDB.DataSource = table;
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
            connection.Open();
            this.ViewAMovies();
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //do nothing
        }

        private void BrowseMoviesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

    }
}
