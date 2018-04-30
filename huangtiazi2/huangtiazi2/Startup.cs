using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Huangtaizi.Startup))]
namespace Huangtaizi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
