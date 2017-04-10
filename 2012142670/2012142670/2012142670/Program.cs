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
           
            
            //ingresando datos a las clases
            evaluacion.AgregarCliente("carmen tineo","46151814","1200");
            evaluacion.AgregarCliente("harold medina", "46307180", "1000");
            evaluacion.AgregarTipoPago("Efectivo");
            evaluacion.AgregarTipoPago("Credito");
            evaluacion.AgregarTipoTrabajador("Asesor");
            evaluacion.AgregarTipoTrabajador("Supervisor");
            evaluacion.AgregarTipoTrabajador("Vendedor");
            evaluacion.AgregarTrabajador("01", "Javier Florez", "1");
            evaluacion.AgregarTrabajador("02", "Santa Perez", "2");
            evaluacion.AgregarTrabajador("03", "Remigio Tume", "1");
            evaluacion.AgregarTrabajador("04", "Ada Guille", "3");
            evaluacion.AgregarTipoEvaluacion("Renovacion de Contrato");
            evaluacion.AgregarTipoEvaluacion("Portabilidad");
            evaluacion.AgregarTipoEvaluacion("Linea Nueva");


            //evaluar cliente y planes
            evaluacion.generarEvaluacion(1);








            Console.WriteLine("Profesor no pude terminar todas las clases!!");
            Console.WriteLine("Sea compasivo");

        }
    }
}
