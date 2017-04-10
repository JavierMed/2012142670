using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace _2012142670
{
    class Program
    {
        static void Main(string[] args)
        {
            var evaluacion = new Evaluacion();

            evaluacion.AgregarCliente("carmen tineo","46151814","1200");
            evaluacion.AgregarCliente("harold medina", "46307180", "1000");


            Console.WriteLine("Hola como estas");
        }
    }
}
