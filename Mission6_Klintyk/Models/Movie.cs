﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_Klintyk.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int FilmID { get; set; }
        [Required]
        //foreign key to category table
        public int CategoryId { get; set; }
        public CategoryResponse Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent_to { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
