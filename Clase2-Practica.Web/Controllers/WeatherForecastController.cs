using Clase2_Practica.Entidades;
using Clase2_Practica.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase2_Practica.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecastService.ObtenerTodos();
        }

        [HttpPost]
        public IEnumerable<WeatherForecast> Post(WeatherForecast weatherForecast)
        {
            return _weatherForecastService.Insertar(weatherForecast);
        }

        [HttpDelete]
        public IEnumerable<WeatherForecast> Delete(DateTime weatherForecastDate)
        {
            return _weatherForecastService.Borrar(weatherForecastDate);
        }
    }
}
