using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace SPACoreVue.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        public static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Warm",
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            var i = 1;
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Id = i++,
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
            });
        }
    }

    public class WeatherForecast
    {
        public int Id { get; set; }
        public string DateFormatted { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
        public int TemperatureF { 
            get
            {
            return 32 + (int)(TemperatureC/0.566);
            }
        }
    }
}