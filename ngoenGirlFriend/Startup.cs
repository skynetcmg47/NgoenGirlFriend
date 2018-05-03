using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ngoenGirlFriend.Startup))]
namespace ngoenGirlFriend
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
