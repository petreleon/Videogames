using System.ComponentModel.DataAnnotations;

namespace Videogames.Models
{
    public class Game
    {

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Producer { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        public ICollection<Review>? Reviews { get; }
    }
}
