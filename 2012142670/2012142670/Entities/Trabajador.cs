using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Trabajador
    {
        public string codTrabajador;
        public string nombre;
        public string tipoTraba;

        public Trabajador(string cod,string nom,string tipo)
        {
            codTrabajador = cod;
            nombre = nom;
            tipoTraba = tipo;
        }
    }
}
