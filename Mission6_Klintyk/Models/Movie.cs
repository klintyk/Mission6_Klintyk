using System;
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
        [Required (ErrorMessage = "YOU HAVE TO SELECT A CATEGORY")]
        //foreign key to category table
        public int CategoryId { get; set; }
        public CategoryResponse Category { get; set; }
        [Required (ErrorMessage = "THE FILM NEEDS A TITLE")]
        public string Title { get; set; }
        [Required (ErrorMessage = "THE FILM NEEDS TO ENTER THE YEAR THAT THE FILM WAS RELEASED EG. 2004")]
        public int Year { get; set; }
        [Required (ErrorMessage = "THE FILM NEEDS A DIRECTOR TITLE")]
        public string Director { get; set; }
        [Required (ErrorMessage = "THE FILM NEEDS A RATING")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent_to { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
