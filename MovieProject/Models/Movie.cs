using MovieProject.Enum;
using System.ComponentModel.DataAnnotations;

namespace MovieProject.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }

        public string Time { get; set; }
        public string Type { get; set; }
        public TypeOfMovies TypeOfMovies { get; set; }
    }
}
