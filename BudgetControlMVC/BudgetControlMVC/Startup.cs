using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BudgetControlMVC.Startup))]
namespace BudgetControlMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
