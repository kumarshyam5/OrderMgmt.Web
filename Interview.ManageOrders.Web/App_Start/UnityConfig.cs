using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Interview.ManageOrders.BusinessServices.Interfaces;
using Interview.ManageOrders.BusinessServices.Services;
using Interview.ManageOrders.BusinessEntities.UnitOfWork;
using System.Web.Http;

namespace Interview.ManageOrders.Web
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();
		   
			
			container.RegisterType<IOrderService, OrderServices>();
			container.RegisterType<IUnitOfWork, UnitOfWork>();

			DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

			GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
		}
	}
}