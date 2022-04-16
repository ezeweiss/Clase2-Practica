using Clase2_Practica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase2_Practica.Servicios.Implementaciones
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private static List<WeatherForecast> _forecastList = new List<WeatherForecast>();

        private static string[] _summaries = new string[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> ObtenerTodos()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = _summaries[rng.Next(_summaries.Length)]
            })
            .ToArray();
        }

        public IEnumerable<WeatherForecast> Insertar(WeatherForecast weatherForecast)
        {
            _forecastList.Add(weatherForecast);
            return _forecastList;
        }

        public IEnumerable<WeatherForecast> Borrar(DateTime weatherForecastDate)
        {
            _forecastList.RemoveAll(x => x.Date == weatherForecastDate);

            #region Opcion Legacy
            //Opcion Legacy
            //WeatherForecast itemABorrar = null;
            //foreach (var weatherForecast in ForecastList)
            //{
            //    if (weatherForecast.Date == weatherForecastDate)
            //    {
            //        itemABorrar = weatherForecast; 
            //    }
            //}
            //if (itemABorrar != null)
            //{
            //    ForecastList.Remove(itemABorrar);
            //}
            #endregion
            
            return _forecastList;
        }

    }
}
