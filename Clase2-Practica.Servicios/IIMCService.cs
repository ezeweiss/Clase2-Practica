using Clase2_Practica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Practica.Servicios
{
    public interface IIMCService
    {
        public double calcularIMC(double peso, double altura);
    }
}
