
using Microsoft.AspNetCore.Mvc;
using Clase2_Practica.Servicios;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clase2_Practica.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadorIMCController : ControllerBase
    {
        private readonly IIMCService _imcService;
        private readonly ILogger _logger;

        public CalculadorIMCController(ILogger<CalculadorIMCController> logger, IIMCService imcService)
        {
            _logger = logger;
            _imcService = imcService;
        }
        // GET: api/<CalculadorIMCController>
        [HttpGet]
        public double obtenerCalculo(double peso, double altura)
        {             
            return _imcService.calcularIMC(peso, altura); 
        }
    }
}
