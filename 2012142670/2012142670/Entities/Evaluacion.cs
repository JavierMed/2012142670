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
        List<TipoPago> _tipoPago;
        List<TipoTrabajador> _tipoTrabajador;
        List<Trabajador> _trabajador;
        List<TipoEvaluacion> _tipoEvaluacion;


        public Evaluacion() {
            EstadoEvaluacion obj = new EstadoEvaluacion();
            

            if (obj.estado==true) {

            }else
            {

            }  
          
        }

        //metodos para agregar una base de datos virtual

        public void AgregarCliente(string nom, string dni, string sueldo)
        {
            _cliente.Add(new Cliente(nom, dni, sueldo));
        }
        public void AgregarTipoPago(string tipo)
        {
            _tipoPago.Add(new TipoPago(tipo));
        }
        public void AgregarTipoTrabajador(string tipoTra)
        {
            _tipoTrabajador.Add(new TipoTrabajador(tipoTra));
        }
        public void AgregarTrabajador(string cod, string nom, string tipo)
        {
            _trabajador.Add(new Trabajador(cod,nom,tipo));
        }
        public void AgregarTipoEvaluacion(string tipo)
        {
            _tipoEvaluacion.Add(new TipoEvaluacion(tipo));
        }


        public void AgregarTipoPlan(string tipo){
            new Plan
                //Add(new TipoPlan(tipo));
            
        }
    }
}
