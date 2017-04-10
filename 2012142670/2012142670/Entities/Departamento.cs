using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Departamento
    {
        string nombreDepartamento { get; set; }

        public Departamento(string nomDep)
        {
            nombreDepartamento = nomDep;
        }
    }
}
