using System;
using System.ComponentModel.DataAnnotations;//Import to use DataType DateTime
using System.ComponentModel.DataAnnotations.Schema;// Import to use Column

namespace MovieWeb.Models
{
    public class Movie
    {
        public int Id {get; set;}
        public string Name {get;set;}

        [Display(Name = "Release Name")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;  }
        public string Genre {get; set;}

        [Column(TypeName = "demical(18,2)")]
        public decimal Price {get; set;}
    }
}