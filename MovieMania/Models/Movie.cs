using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MovieMania.Models
{
    [Index(nameof(MovieName), IsUnique =true)]
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name of movie is required")]
        public string MovieName { get; set; }
        [Required(ErrorMessage ="Producer should be present")]
        public string Producer { get; set;}

        public double Ticket { get; set;}   

        public DateOnly ReleaseDate { get; set;}    
    }
}
