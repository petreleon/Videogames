using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Videogames.Data;


namespace Videogames.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VideogamesContext(
                serviceProvider.GetRequiredService<DbContextOptions<VideogamesContext>>()))
            {
                // Look for any games.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                var games = new List<Game>
                {
                    new Game
                    {
                        Title = "The Legend of Zelda: Breath of the Wild",
                        Producer = "Nintendo",
                        ReleaseDate = new DateTime(2017, 3, 3),
                        Genre = "Action-Adventure",
                        Price = 59.99M
                    },
                    new Game
                    {
                        Title = "Red Dead Redemption 2",
                        Producer = "Rockstar Games",
                        ReleaseDate = new DateTime(2018, 10, 26),
                        Genre = "Action-Adventure",
                        Price = 49.99M
                    },
                    new Game
                    {
                        Title = "Super Mario Odyssey",
                        Producer = "Nintendo",
                        ReleaseDate = new DateTime(2017, 10, 27),
                        Genre = "Platformer",
                        Price = 49.99M
                    },
                    new Game
                    {
                        Title = "God of War",
                        Producer = "Santa Monica Studio",
                        ReleaseDate = new DateTime(2018, 4, 20),
                        Genre = "Action-Adventure",
                        Price = 19.99M
                    },
                    new Game
                    {
                        Title = "Minecraft",
                        Producer = "Mojang",
                        ReleaseDate = new DateTime(2011, 11, 18),
                        Genre = "Sandbox, Survival",
                        Price = 26.95M
                    },
                    new Game
                    {
                        Title = "Overwatch",
                        Producer = "Blizzard Entertainment",
                        ReleaseDate = new DateTime(2016, 5, 24),
                        Genre = "First-person shooter",
                        Price = 39.99M
                    },
                    new Game
                    {
                        Title = "Fortnite",
                        Producer = "Epic Games",
                        ReleaseDate = new DateTime(2017, 7, 25),
                        Genre = "Battle Royale",
                        Price = 0M
                    },
                    new Game
                    {
                        Title = "Cyberpunk 2077",
                        Producer = "CD Projekt",
                        ReleaseDate = new DateTime(2020, 12, 10),
                        Genre = "Role-playing",
                        Price = 59.99M
                    },
                    new Game
                    {
                        Title = "The Witcher 3: Wild Hunt",
                        Producer = "CD Projekt",
                        ReleaseDate = new DateTime(2015, 5, 19),
                        Genre = "Role-playing",
                        Price = 39.99M
                    },
                    new Game
                    {
                        Title = "Apex Legends",
                        Producer = "Respawn Entertainment",
                        ReleaseDate = new DateTime(2019, 2, 4),
                        Genre = "Battle Royale",
                        Price = 0M
                    },
                    new Game
                    {
                        Title = "Among Us",
                        Producer = "InnerSloth",
                        ReleaseDate = new DateTime(2018, 6, 15),
                        Genre = "Party, Strategy",
                        Price = 5.00M
                    },
                    new Game
                    {
                        Title = "Fall Guys: Ultimate Knockout",
                        Producer = "Mediatonic",
                        ReleaseDate = new DateTime(2020, 8, 4),
                        Genre = "Battle Royale",
                        Price = 19.99M
                    },
                    new Game
                    {
                        Title = "Call of Duty: Warzone",
                        Producer = "Infinity Ward",
                        ReleaseDate = new DateTime(2020, 3, 10),
                        Genre = "Battle Royale",
                        Price = 0M
                    },
                    new Game
                    {
                        Title = "Hades",
                        Producer = "Supergiant Games",
                        ReleaseDate = new DateTime(2020, 9, 17),
                        Genre = "Rogue-like",
                        Price = 24.99M
                    },
                    new Game
                    {
                        Title = "Hollow Knight",
                        Producer = "Team Cherry",
                        ReleaseDate = new DateTime(2017, 2, 24),
                        Genre = "Action-adventure",
                        Price = 15.00M
                    },
                    new Game
                    {
                        Title = "Doom Eternal",
                        Producer = "id Software",
                        ReleaseDate = new DateTime(2020, 3, 20),
                        Genre = "First-person shooter",
                        Price = 59.99M
                    },
                    new Game
                    {
                        Title = "The Last of Us Part II",
                        Producer = "Naughty Dog",
                        ReleaseDate = new DateTime(2020, 6, 19),
                        Genre = "Action-adventure",
                        Price = 59.99M
                    },
                    new Game
                    {
                        Title = "Monster Hunter: World",
                        Producer = "Capcom",
                        ReleaseDate = new DateTime(2018, 1, 26),
                        Genre = "Action role-playing",
                        Price = 29.99M
                    },
                    new Game
                    {
                        Title = "Sekiro: Shadows Die Twice",
                        Producer = "FromSoftware",
                        ReleaseDate = new DateTime(2019, 3, 22),
                        Genre = "Action-adventure",
                        Price = 59.99M
                    },
                    new Game
                    {
                        Title = "Assassin's Creed Valhalla",
                        Producer = "Ubisoft",
                        ReleaseDate = new DateTime(2020, 11, 10),
                        Genre = "Action role-playing",
                        Price = 59.99M
                    },
                    new Game
                    {
                        Title = "Horizon Zero Dawn",
                        Producer = "Guerrilla Games",
                        ReleaseDate = new DateTime(2017, 2, 28),
                        Genre = "Action role-playing",
                        Price = 19.99M
                    },
                    new Game
                    {
                        Title = "Genshin Impact",
                        Producer = "miHoYo",
                        ReleaseDate = new DateTime(2020, 9, 28),
                        Genre = "Action role-playing",
                        Price = 0M
                    },
                    new Game
                    {
                        Title = "Valorant",
                        Producer = "Riot Games",
                        ReleaseDate = new DateTime(2020, 6, 2),
                        Genre = "Tactical shooter",
                        Price = 0M
                    }

                };

                foreach (var game in games)
                {
                    context.Game.Add(game);
                }

                context.SaveChanges();
            }
        }
    }
}
