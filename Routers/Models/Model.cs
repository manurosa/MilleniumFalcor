namespace Routers.Model
{
    using System.Collections.Generic;

    public class Model
    {
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<Planet> Planets { get; set; }
        public IEnumerable<Film> Films { get; set; }
    }
}