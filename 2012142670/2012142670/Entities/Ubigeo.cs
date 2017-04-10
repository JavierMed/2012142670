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

        List<Departamento> _depar;
        List<Provincia> _prov;
        List<Distrito> _dist;

        public Ubigeo(string distri, string prov, string depart)
        {
            _depar.Add(new Departamento(depart));
            _prov.Add(new Provincia(prov));
            _dist.Add(new Distrito(distri));
        }
    }
}
