﻿using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class MovieList : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Size = 0;

        public MovieList()
        {
            Size = 0;
        }

        public void IncrementSize()
        {
            Size += 1;
        }

        public void DecrementSize()
        {
            Size -= 1;
        }

    }
}
