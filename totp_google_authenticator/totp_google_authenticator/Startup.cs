using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(totp_google_authenticator.Startup))]
namespace totp_google_authenticator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
