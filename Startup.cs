using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(One_21MAR.Startup))]
namespace One_21MAR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
