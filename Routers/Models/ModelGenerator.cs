namespace Routers.Model
{
    using System.Collections.Generic;
    using System.Linq;

    public class ModelGenerator
    {
        public Model Generate()
        {
            return new Model
            {
                People = this.people,
                Films = this.films,
                Planets = this.planets
            };
        }

        private readonly List<Person> people;

        private readonly List<Film> films = new List<Film>
        {
            new Film { Title = "The Empire strikes back" },
            new Film { Title = "A new hope" }
        };

        private readonly List<Planet> planets = new List<Planet>
        {
            new Planet { Name = "Earth" },
            new Planet { Name = "Tatooine" }
        };

        public ModelGenerator()
        {
            this.people = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "Han Solo",
                    Planet = this.planets.FirstOrDefault(),
                    BirthYear = "1984",
                    Films = this.films.Find(f => f.Title == "The Empire strikes back")
                },
                new Person
                {
                    Id = 2,
                    Name = "Darth Vader",
                    Planet = this.planets.Find(p => p.Name == "Tatooine"),
                    BirthYear = "2009",
                    Films = this.films.Find(f => f.Title == "A new hope")
                }
            };
        }
    }
}