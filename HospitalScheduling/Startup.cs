using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalScheduling.Startup))]
namespace HospitalScheduling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
