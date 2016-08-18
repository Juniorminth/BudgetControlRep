using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherForecast.Models
{
    public class CityDataModel
    {
        public string stateName { get; set; }
        public string shortStateName { get; set; }
        public string stateCode { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
    }
}