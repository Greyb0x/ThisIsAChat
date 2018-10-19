using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThisIsAChat.Startup))]
namespace ThisIsAChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
