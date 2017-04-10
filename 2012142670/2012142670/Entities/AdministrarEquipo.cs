using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class AdministrarEquipo
    {
        int stockModelo;
        string modelo;

        public AdministrarEquipo(int stockModelo, string modelo)
        {
            this.stockModelo = stockModelo;
            this.modelo = modelo;
        }
    }
}
