using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Plan
    {
        private List<TipoPlan> _tipoPlan;

        //public TipoPlan tipoPlan {get{return _tipoPlan;}}

        public Plan(){
            _tipoPlan = new List<TipoPlan>();
        }

        public void Agregar(string tipoPlan)
        {
            _tipoPlan.Add(new TipoPlan(tipoPlan));
        }

    }
}
