using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Ubigeo
    {
        public string ubigeo { get; set; }

        public Ubigeo(string distri, string prov, string depart)
        {
            new Departamento(depart);
            new Provincia(prov);
            new Distrito(distri);
        }
    }
}
