namespace Routers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Model;

    public class StarWarsService
    {
        private Model.Model Model { get; }
        public StarWarsService()
        {
            this.Model = new ModelGenerator().Generate();
        }

        public async Task<List<Person>> GetCharactersAsync()
        {
            await Task.Delay(500);

            return this.Model.People.ToList();
        }
    }
}
