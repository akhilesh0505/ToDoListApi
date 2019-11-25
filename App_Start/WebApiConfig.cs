using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ToDoListApi.Models;
using ToDoListApi.Services;
using Unity;
using Unity.Lifetime;

namespace ToDoListApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
			// Web API configuration and services
			var container = new UnityContainer();
			container.RegisterType<IToDoListService, ToDoListService>(new HierarchicalLifetimeManager());
			container.RegisterType<IToDoListRepository, InMemoryToDoListRepository>(new HierarchicalLifetimeManager());
			config.DependencyResolver = new UnityResolver(container);

			// Web API routes
			config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { action = "Get", id = RouteParameter.Optional }
            );
        }
    }
}
