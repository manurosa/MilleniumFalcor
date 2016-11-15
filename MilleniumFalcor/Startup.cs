using Microsoft.Owin;
using MilleniumFalcor;

[assembly: OwinStartup(typeof(Startup))]

namespace MilleniumFalcor
{
    using Falcor.Server.Owin;
    using Owin;
    using Routers;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseFalcor("/model.json", config => new StarWarsRouter());
            
            app.UseStaticFiles();
        }
    }
}