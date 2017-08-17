using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//to

namespace ccl.Negocio
{
    public class Empleado : IPersona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Cargo { get; set; }
        public float Sueldo{ get; set; }
        private Random random;

        public Empleado(string nombre, float sueldo) {
            random = new Random();
            Id = random.Next(1000);
            this.Nombre = nombre;
            this.Sueldo = sueldo;


        }
    }
}
