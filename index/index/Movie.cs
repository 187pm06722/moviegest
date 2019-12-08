using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    public partial class Movie
    {
        public int index { get; set; }
        public int budget { get; set; }
        public string genres { get; set; }
        public int id { get; set; }
        public string keywords { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public float popularity { get; set; }
        public DateTime release_date { get; set; }
        public int runtime  { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string title { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
        public string cast { get; set; }
        public string director { get; set; }

    }
}
