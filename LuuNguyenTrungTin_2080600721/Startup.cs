using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuuNguyenTrungTin_2080600721.Startup))]
namespace LuuNguyenTrungTin_2080600721
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
