using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WeatherForecast
{
    public static class WebApiConfig
    {
        [HttpGet]
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "GetCities",
                routeTemplate: "api/CityController/GetCities",
                defaults: new { id= RouteParameter.Optional, action= "GetCities"}                
                );
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
