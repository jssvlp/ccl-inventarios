using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccl.Negocio
{
    class Pasivo
    {
        public int IdPasivo { get;  }
        public int DescripcionPasivo { get; set; }
        public Decimal Monto { get; set; }
    }
}
