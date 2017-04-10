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
            _tipoPago = new List<TipoPago>();
            _tipoEvaluacion = new List<TipoEvaluacion>();
            _tipoTrabajador = new List<TipoTrabajador>();
            _trabajador = new List<Trabajador>();
            _cliente = new List<Cliente>();

            if (obj.estado==true) {

            }else
            {

            }  
          
        }


        //metodos para agregar una base de datos virtual

        public void AgregarCliente(string nom, string dni, string sueldo)
        {
            try
            {
                _cliente.Add(new Cliente(nom, dni, sueldo));
            }
            catch(Exception e)
            {
                Console.Write(e);
            }
        }
        public void AgregarTipoPago(string tipo)
        {
            try
            {
                _tipoPago.Add(new TipoPago(tipo));
            }
            catch (Exception e)
            {
                Console.Write(e);
            }            
        }
        public void AgregarTipoTrabajador(string tipoTra)
        {
            try
            {
                _tipoTrabajador.Add(new TipoTrabajador(tipoTra));
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            
        }
        public void AgregarTrabajador(string cod, string nom, string tipo)
        {
            try
            {
                _trabajador.Add(new Trabajador(cod, nom, tipo));
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            
        }
        public void AgregarTipoEvaluacion(string tipo)
        {
            try
            {
                _tipoEvaluacion.Add(new TipoEvaluacion(tipo));
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            
        }

        public void generarVenta()
        {

        }
        public bool generarEvaluacion(int rand)
        {
            bool evaluacion=true;

            if (rand==1)
            {
                Console.WriteLine("Cliente[{0}]:", _cliente[0].nombre);
                Console.WriteLine("");
                Console.WriteLine("Trabajador[{0}]:",_trabajador[4].nombre);
                Console.WriteLine("");
                Console.WriteLine("Tipo Pago[{0}]:",_tipoPago[0]);
                Console.WriteLine("");
                return evaluacion;
            }else
            {

                Console.WriteLine("Cliente no puede acceder a un plan postpago");
                Console.WriteLine("No tiene plata...misio!!");
                return false;
            }            
        }

        public void AgregarTipoPlan(string tipo){
            //new Plan
                //Add(new TipoPlan(tipo));
            
        }
    }
}
