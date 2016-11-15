namespace Routers.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthYear { get; set; }
        public Planet Planet { get; set; }
        public Film Films { get; set; }
    }
}