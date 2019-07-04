using ReelRate.Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReelRate.Project.Models
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string Poster { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public int TMDB_ID { get; set; }
    }
}
