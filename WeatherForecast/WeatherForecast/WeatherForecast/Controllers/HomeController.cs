using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;  
using WeatherForecast.Models;

namespace WeatherForecast.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string GetCity(string shortCut = "")
        {
            CityController controller = new CityController();
            return JsonConvert.SerializeObject(controller.GetCities(shortCut));
        }

        public string GetCityWeather(string zip)
        {
            CityController controller = new CityController();
            return JsonConvert.SerializeObject(controller.GetWeather(zip));
        }
    }
}