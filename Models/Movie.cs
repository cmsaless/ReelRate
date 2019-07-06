using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Movie : BaseEntity
    {
        [Display(Name = "Movie Database ID")]
        public int TMDB_ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Year of Release")]
        public string Year { get; set; }
        public string Poster { get; set; }
    }
}
