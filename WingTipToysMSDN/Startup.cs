using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WingTipToysMSDN.Startup))]
namespace WingTipToysMSDN
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
