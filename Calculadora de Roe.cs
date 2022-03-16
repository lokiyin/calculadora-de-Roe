using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Calculadora Y graficadora de Roe BY LU9HMB");
            Console.WriteLine("Indique la cantidad de Frecuencias a analiazar");
            int cant ;
            cant = int.Parse(Console.ReadLine());
            
            Grafica[] matrisLista = new Grafica[cant];
            
            for (int i = 0; i < matrisLista.Length; i++)
            {
                double _directa;
                double _refle;
                double ROE ;
                double frecuencia;
                Console.WriteLine("Frecuencia " + i +":");

                Console.WriteLine("escrba la frecuencia");
                frecuencia = double.Parse(Console.ReadLine());

                Console.WriteLine("escrba la potencia directa");
                _directa = double.Parse(Console.ReadLine());

                Console.WriteLine("Escribe la reflejada ");
                _refle = double.Parse(Console.ReadLine());

                ROE = (1 + Math.Sqrt(_refle / _directa)) / (1 - Math.Sqrt(_refle / _directa));

                Console.WriteLine("La Roe para la frecuencia " + frecuencia +" es: " + "{0:N2}", ROE);
                Console.ReadKey();

                matrisLista[i] = new Grafica(frecuencia.ToString(), ROE.ToString("0.00") ) ;

                Console.Clear();

            }
            Console.WriteLine("--Frecuencia--" + "---Roe---");
            for (int i = 0; i < matrisLista.Length; i++)
            {

                Console.WriteLine(matrisLista[i].leerTabla());
            }

            
            Console.ReadKey();

        }     
    }
    class Grafica
    {
        public Grafica(string freq, string swr)
        {
            this.freq = freq;
            this.swr = swr;
        }
        
    public string leerTabla()
        {
            return "     "+ freq + "       "+ swr;

        }
        private string freq;
        private string swr;
    }

}
