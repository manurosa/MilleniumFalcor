namespace Routers
{
    using System.Collections.Generic;
    using System.Linq;
    using Falcor.Server;

    public class StarWarsRouter : FalcorRouter
    {
        public StarWarsRouter()
        {
            this.Get["person[{ranges:id}]"] = async parameters =>
            {
                var service = new StarWarsService();

                var people = await service.GetCharactersAsync();

                List<int> indices = parameters.id;

                var results = indices.Select(index =>
                                             {
                                                 var person = people.ElementAtOrDefault(index);

                                                 return person != null
                                                    ? Path("person", index, "name").Atom(person.Name)
                                                    : Path("person", index).Undefined();
                                             });

                return Complete(results);
            };
        }
    }
}
