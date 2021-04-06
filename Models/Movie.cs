using System;
using System.ComponentModel.DataAnnotations;//Import to use DataType DateTime

namespace MovieWeb.Models
{
    public class Movie
    {
        public int Id {get; set;}
        public string Name {get;set;}

        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;  }
        public string Genre {get; set;}
        public decimal Price {get; set;}
    }
}