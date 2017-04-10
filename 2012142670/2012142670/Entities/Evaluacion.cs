using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Evaluacion
    {
        List<Cliente> _cliente;


        public Evaluacion() {
            EstadoEvaluacion obj = new EstadoEvaluacion();
            

            if (obj.estado==true) {

            }else
            {

            }  
          
        }

        public void AgregarCliente(string nom, string dni, string sueldo)
        {
            _cliente.Add(new Cliente(nom, dni, sueldo));
        }



        public void AgregarTipoPlan(string tipo){
            new Plan
                //Add(new TipoPlan(tipo));
            
        }
    }
}
