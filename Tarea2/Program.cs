using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2.Entidades;
using Tarea2.Negocios;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra");
            Palabra palabra = new Palabra();
            palabra.palabra = Console.ReadLine();

            ClsPalabra contar = new ClsPalabra();

            Console.WriteLine("La palabra " + palabra.palabra + " tiene " + contar.contador(palabra) + " letras");
            Console.ReadKey();
        }
    }
}
