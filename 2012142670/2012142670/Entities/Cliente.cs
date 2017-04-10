using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Cliente
    {
        public string nombre;
        public string dni;
        public string sueldo;
        public Cliente() { }

        public Cliente(string nom,string dni,string sueldo){
            nombre = nom;
            this.dni = dni;
            this.sueldo = sueldo;
        }
    }
}
