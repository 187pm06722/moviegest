using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    class moviesManagement
    {
        public Movie[] GetMovies()
        {
            var db = new moviegestDBEntities01();
            var movies = db.Set<Movie>().ToArray();
            return movies;
        }
    }
}
