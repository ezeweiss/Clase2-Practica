using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Practica.Entidades
{
    public class Imc
    {
        public double Peso { get; set; }
        public double Altura { get; set; }

        public Imc(double Peso, double Altura)
        {
            Peso = Peso;
            Altura = Altura;
        }

    }

}
