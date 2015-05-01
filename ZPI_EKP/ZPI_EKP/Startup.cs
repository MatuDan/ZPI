using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZPI_EKP.Startup))]
namespace ZPI_EKP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
