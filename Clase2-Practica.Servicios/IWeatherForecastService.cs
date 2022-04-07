using Clase2_Practica.Entidades;
using System;
using System.Collections.Generic;

namespace Clase2_Practica.Servicios
{
    public interface IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> ObtenerTodos();
        public IEnumerable<WeatherForecast> Insertar(WeatherForecast weatherForecast);
        public IEnumerable<WeatherForecast> Borrar(DateTime weatherForecastDate);
    }
}