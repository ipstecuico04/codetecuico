using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(codetecuico.chat.Startup))]
namespace codetecuico.chat
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
