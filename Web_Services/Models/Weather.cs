using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Services;

namespace Web_Services.Models
{
    public class Weather
    {
        public int WeatherID { get; set; }
        public string Date { get; set; }
        public string Desciption { get; set; }
        public string MorningLow { get; set; }
        public string DaytimeHigh { get; set; }
    }
}