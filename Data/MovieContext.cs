using Microsoft.EntityFrameworkCore;
using MovieWeb.Models;


namespace MovieWeb.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options){

        }

        public DbSet<Movie> Movies {get; set;} //Entity set in Entity Framework technology is a database table, an entity is a row in the table
    }
}