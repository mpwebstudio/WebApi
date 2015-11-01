using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataCleansing.Web.Startup))]
namespace DataCleansing.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
