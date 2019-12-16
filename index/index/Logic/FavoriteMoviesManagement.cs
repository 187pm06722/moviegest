using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.ProviderBase;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using IronPython;
using System.Diagnostics;


namespace index
{
    
    class FavoriteMoviesManagement
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        SqlCommand command;
        //string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\augus\OneDrive\Documents\moviegestDB.mdf;Integrated Security=True;Connect Timeout=30";
        string pythonfilePath = @"C:\Users\augus\PycharmProjects\RecommendationSystem\model.py";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public movie_dataset_fixed[] GetFavoriteMovies()
        {


            return null;
        }

      

        public void AddMovies()
        {
            //
        }

        public void EditMovie()
        {
            //
        }

        public void DeleteMovie()
        {

        }

        public void AddToFavorite()
        {

        }

        public string getTitleFromIndex()
        {
            string resultTitle = "";

            return resultTitle;
        }

        public void pythonRead()
        {
            var engine = IronPython.Hosting.Python.CreateEngine();
            var pythonScript = engine.CreateScriptSourceFromFile(pythonfilePath);

            var argv = new List<string>();
            argv.Add("");
            argv.Add("Avatar");

            //engine.Execute()


            
        }

        public void pythonProcess()
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\augus\AppData\Local\Programs\Python\Python37\python.exe";

            var script = @"C:\Users\augus\source\repos\moviegest01\moviegest\index\index\Logic\Python\model.py";
            string mTitle = "Avatar";

            //psi.Arguments = $"\" {script}  \"\  \"\"  \"";

        }

        

    }
}
