using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_Klintyk.Models
{
    public class CategoryResponse
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Category { get; set; }

    }
}
