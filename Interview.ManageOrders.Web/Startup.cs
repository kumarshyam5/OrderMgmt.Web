using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Interview.ManageOrders.Web.Startup))]
namespace Interview.ManageOrders.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
