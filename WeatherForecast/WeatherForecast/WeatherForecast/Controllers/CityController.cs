using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using Newtonsoft.Json;

namespace WeatherForecast.Controllers
{
    [Route("api/CityController")]
    public class CityController : ApiController
    {
        [Route("api/CityController/GetCities/{filter}")]
        [HttpGet]
        public List<WeatherForecast.Models.CityDataModel> GetCities(string filter = "")
        {
            List<WeatherForecast.Models.CityDataModel> cities = new List<Models.CityDataModel>();
            string jsonFile = File.ReadAllText(AppContext.BaseDirectory + @"JSON\citydata.json");
            cities = JsonConvert.DeserializeObject<List<WeatherForecast.Models.CityDataModel>>(jsonFile);
            if (!string.IsNullOrEmpty(filter) && filter.Length > 1)
            {
                cities = cities.Where(x => x.city.ToLower().StartsWith(filter.ToLower())).ToList();
            }

            return cities;
        }

        [Route("api/CityController/GetWeather/{cityzip}")]
        [HttpGet]
        public com.cdyne.wsf.WeatherReturn GetWeather(string cityZip = "")
        {
            if (!string.IsNullOrEmpty(cityZip))
            {
                com.cdyne.wsf.Weather client = new com.cdyne.wsf.Weather();
                var resp = client.GetCityWeatherByZIP(cityZip);
                return resp;
            }
            return null;
        }
    }
}
