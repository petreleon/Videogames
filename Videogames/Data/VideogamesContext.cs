using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Videogames.Models;

namespace Videogames.Data
{
    public class VideogamesContext : DbContext
    {
        public VideogamesContext (DbContextOptions<VideogamesContext> options)
            : base(options)
        {
        }

        public DbSet<Videogames.Models.Game> Game { get; set; } = default!;

        public DbSet<Videogames.Models.Review>? Review { get; set; }
    }
}
