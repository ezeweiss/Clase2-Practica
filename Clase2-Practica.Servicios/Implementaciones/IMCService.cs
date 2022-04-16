using Clase2_Practica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace Clase2_Practica.Servicios.Implementaciones
{
    public class IMCService : IIMCService
    {
       public double calcularIMC(double peso, double altura)
        {
            double imc;
            imc = peso / (altura * altura);
            return imc;  
        } 
    }
}
