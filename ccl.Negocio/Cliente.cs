using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccl.Negocio
{
    public class Cliente : IPersona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        private Random random;
        private List<Colmado> colmados;

        public Cliente(string nombre, Colmado colmado) {
            Id = random.Next(1000);
            this.Nombre = nombre;
            if (colmados == null)
                colmados = new List<Colmado>();
            colmados.Add(colmado);
        }

        public Cliente(string nombre) {
            this.Nombre = nombre;
        }
        public List<Colmado> getColmados() {
            return colmados;
        }

        public void agregarColmado(Colmado colmado) {
            colmados.Add(colmado);
        }

        


    }
}
