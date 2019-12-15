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
using System;
using System.Windows.Forms;

namespace index.Forms
{
    public partial class BrowseMoviesForm : Form
    {
        private FavoriteMoviesManagement Business;
        private string MovieTitle;
        private bool isEmpty = true;
        //SqlConnection connection = new;

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        SqlCommand command;
        string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\augus\OneDrive\Documents\moviegestDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public BrowseMoviesForm()
        {
            InitializeComponent();
            this.Business = new FavoriteMoviesManagement();
            this.MovieTitle = this.txtSearch.Text;
            this.Load +=BrowseMoviesForm_Load;
            this.btnSave.Click += BtnSave_Click;
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
            if(this.txtSearch.Text.Equals(""))
            {
                return;
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM movie_dataset_fixed where title like ('%" + this.txtSearch.Text + "%')";
                adapter.SelectCommand = command;
                //table.Clear();
                adapter.Fill(table);
                grdDB.DataSource = table;
            }
            
            
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
            try
            {
                connection.Open();
                this.ViewAMovies();
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void BrowseMoviesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void clearResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if(grdDB.Rows.Count==0)
            {
                return;
            }
            StringBuilder stringbuild = new StringBuilder();
            string columnsHeader = "";
           for (int i = 0; i < grdDB.Columns.Count; i++)
           {
               columnsHeader += grdDB.Columns[i].Name + ",";
           }
           stringbuild.Append(columnsHeader + Environment.NewLine);
             foreach (DataGridViewRow grd in grdDB.Rows)
           {
               if (!grd.IsNewRow)
               {
                   for (int c = 0; c < grd.Cells.Count; c++)
                   {
                       stringbuild.Append(grd.Cells[c].Value + ",");
                   }
                   stringbuild.Append(Environment.NewLine);
               }
           }
            
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 3;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog.FileName,false))
                {
                    sw.WriteLine(stringbuild.ToString());
                }
            }
            MessageBox.Show("CSV file saved.");
        }

        private void deleteARecordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow item in this.grdDB.SelectedRows)
            {
                grdDB.Rows.RemoveAt(item.Index);
            }
        }

    }
}
