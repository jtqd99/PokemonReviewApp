using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;

        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        // To seed database using Terminal, run the following command:
        // cd PokemonReviewApp
        // dotnet run seeddata

        public void SeedDataContext()
        {
            if (!dataContext.PokemonOwners.Any())
            {
                var pokemonOwners = new List<PokemonOwner>()
                {
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Pikachu",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Electric"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Pikachu",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pikachu", Text = "Pickachu is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pikachu",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Jack",
                            LastName = "London",
                            Gym = "Brocks Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Squirtle",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Water"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title= "Squirtle", Text = "squirtle is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title= "Squirtle",Text = "Squirtle is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title= "Squirtle", Text = "squirtle, squirtle, squirtle", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Harry",
                            LastName = "Potter",
                            Gym = "Mistys Gym",
                            Country = new Country()
                            {
                                Name = "Saffron City"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Venasuar",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Leaf"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Veasaur",Text = "Venasuar is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Veasaur",Text = "Venasuar is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Veasaur",Text = "Venasuar, Venasuar, Venasuar", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Ash",
                            LastName = "Ketchum",
                            Gym = "Ashs Gym",
                            Country = new Country()
                            {
                                Name = "Millet Town"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Charizard",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Fire"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Charizard",Text = "Charizard is the best pokemon, because it is fire", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "John", LastName = "Doe" } },
                                new Review { Title="Charizard",Text = "Charizard is great at melting ice", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "Jane", LastName = "Doe" } },
                                new Review { Title="Charizard",Text = "Charizard, Charizard, Charizard", Rating = 2,
                                Reviewer = new Reviewer(){ FirstName = "Emily", LastName = "Clark" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Brock",
                            LastName = "Harrison",
                            Gym = "Pewter Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Bulbasaur",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Grass"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Bulbasaur",Text = "Bulbasaur is the best pokemon, because it is grass", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Michael", LastName = "Jordan" } },
                                new Review { Title="Bulbasaur",Text = "Bulbasaur is great at defeating water types", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "LeBron", LastName = "James" } },
                                new Review { Title="Bulbasaur",Text = "Bulbasaur, Bulbasaur, Bulbasaur", Rating = 3,
                                Reviewer = new Reviewer(){ FirstName = "Kobe", LastName = "Bryant" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Misty",
                            LastName = "Williams",
                            Gym = "Cerulean Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Jigglypuff",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Fairy"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Jigglypuff",Text = "Jigglypuff is the best pokemon, because it is fairy", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Serena", LastName = "Williams" } },
                                new Review { Title="Jigglypuff",Text = "Jigglypuff is great at putting enemies to sleep", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "Venus", LastName = "Williams" } },
                                new Review { Title="Jigglypuff",Text = "Jigglypuff, Jigglypuff, Jigglypuff", Rating = 3,
                                Reviewer = new Reviewer(){ FirstName = "Roger", LastName = "Federer" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Gary",
                            LastName = "Oak",
                            Gym = "Viridian Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Eevee",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Normal"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Eevee",Text = "Eevee is the best pokemon, because it can evolve into many forms", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Chris", LastName = "Evans" } },
                                new Review { Title="Eevee",Text = "Eevee is versatile and cute", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "Scarlett", LastName = "Johansson" } },
                                new Review { Title="Eevee",Text = "Eevee, Eevee, Eevee", Rating = 3,
                                Reviewer = new Reviewer(){ FirstName = "Robert", LastName = "Downey Jr." } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Lance",
                            LastName = "Dragon",
                            Gym = "Elite Four",
                            Country = new Country()
                            {
                                Name = "Johto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Gengar",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Ghost"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Gengar",Text = "Gengar is the best pokemon, because it is ghost", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Tom", LastName = "Holland" } },
                                new Review { Title="Gengar",Text = "Gengar is spooky and powerful", Rating = 4,
                                Reviewer = new Reviewer(){ FirstName = "Zendaya", LastName = "Coleman" } },
                                new Review { Title="Gengar",Text = "Gengar, Gengar, Gengar", Rating = 3,
                                Reviewer = new Reviewer(){ FirstName = "Benedict", LastName = "Cumberbatch" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Sabrina",
                            LastName = "Psychic",
                            Gym = "Saffron Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    }
                };
                dataContext.PokemonOwners.AddRange(pokemonOwners);
                dataContext.SaveChanges();
            }
        }
    }
}