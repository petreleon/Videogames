using System;
using System.ComponentModel.DataAnnotations;
using Videogames.Data;

namespace Videogames.Models
{
    public class Review
    {

        public int Id { get; set; }
        public int GameId { get; set; }
        public Game? Game { get; set; }
        public string? ReviewerName { get; set; }
        public string? Comment { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}