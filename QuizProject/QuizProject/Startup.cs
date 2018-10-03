using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizProject.Startup))]
namespace QuizProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
