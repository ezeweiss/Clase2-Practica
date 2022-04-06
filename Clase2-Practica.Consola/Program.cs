using System;
using System.Text;

namespace Clase2_Practica.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerformanceConcatenacionString();
            Console.ReadKey();

            PerformanceConcatenacionStringBuilder();
            Console.ReadKey();
        }

        private static void PerformanceConcatenacionString()
        {
            string texto = "";
            DateTime tiempoInicio = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                texto += i.ToString();
            }

            TimeSpan tiempoEjecucion = DateTime.Now.Subtract(tiempoInicio);

            Console.WriteLine($"Tiempo de ejecucion PerformanceConcatenacionString: {tiempoInicio.Millisecond}ms");
        }

        private static void PerformanceConcatenacionStringBuilder()
        {
            StringBuilder texto = new StringBuilder();
            DateTime tiempoInicio = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                texto.Append(i.ToString());
            }

            TimeSpan tiempoEjecucion = DateTime.Now.Subtract(tiempoInicio);

            Console.WriteLine($"Tiempo de ejecucion PerformanceConcatenacionStringBuilder: {tiempoInicio.Millisecond}ms");
        }

    }
}
