using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    class moviesManagement
    {

        public movie_dataset_fixed[] GetMovies()
        {
            var db = new moviegestDBEntities1();
            var movies = db.movie_dataset_fixed.ToArray();
            return movies;
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

        public movie_dataset_fixed GetMovie(string title)
        {
            var db = new moviegestDBEntities1();
            var movie = db.movie_dataset_fixed.Find(title);
            return movie;
        }


    }
}
