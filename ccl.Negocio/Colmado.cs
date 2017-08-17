using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccl.Negocio
{
    public class Colmado
    {

        public int Id { get; set; }//Identificador unico
        public string Nombre { get; set; }
        public string Propietario { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public  DateTime FechaPrimerInventario { get; set; }
        public Inventario UltimoInventario { get; set; }
        public int Frecuencia { get; set; }// Cantidad de dias que pasa para volver a realizar el inventario
        public float Precio { get; set; } //Costo RD$ del iventario;

        private List<Empleado> Empleados;
        public List<Inventario> Inventarios;
        private Random random; //Provisionar, estas claves deben ser generadas por Entity o por el motor de BD

        //Constructor Provisionar para pruebas, modificado segun las necesidades
        public Colmado(Cliente cliente)
        {
            random = new Random();
            Id = random.Next(1000);//PROV.
            Nombre = "Colmado" + cliente.Nombre;
            Propietario = cliente.Nombre;
            Empleados = new List<Empleado>();

           

        }

        public Colmado(string nomnbre, string propietario, string direccion, string telefono, List<Inventario> inventarios ) {
            
            if (this.Inventarios.Count == 0)
                FechaPrimerInventario = DateTime.Now.Date;
            this.Propietario = propietario;
        }
        
        //Agrega un inventario ya realizado al colmado
        //Entiende que el inventario agregado es el ultimo
        public void AddInventario(Inventario inventario) {
            if (Inventarios == null)
                Inventarios = new List<Inventario>();
            Inventarios.Add(inventario);
            UltimoInventario = inventario;
        }

        //Devuelve un listado con los empleados del colmado
        public List<Empleado> GetEmpleados() {
            return Empleados;
        }

        //Configura los empleados del colmado
        public void SetEmpleado(Empleado empleado) {
            if (Empleados == null)
                Empleados = new List<Empleado>();
            Empleados.Add(empleado);
        }

        //Devuelve UN empleado
        public Empleado GetEmpleado(int id) {
            return Empleados.Find(x => x.Id == id);
            
        }
    }
}
