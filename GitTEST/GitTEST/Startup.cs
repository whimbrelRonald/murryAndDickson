using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTEST.Startup))]
namespace GitTEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
