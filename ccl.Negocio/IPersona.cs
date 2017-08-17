using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccl.Negocio
{
    public interface IPersona
    {
         int Id { get; set; }
         string Nombre { get; set; }
         string Apellidos { get; set; }
         string Telefono { get; set; }
    }
}
