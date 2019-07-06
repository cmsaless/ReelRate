using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class MovieList : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

        public MovieList()
        {
            Movies = new List<Movie>();
        }
    }
}
