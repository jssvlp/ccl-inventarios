using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccl.Negocio
{
    public class Producto
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Medida { get; set; }
        public float Precio { get; set; }
        public string Categoria { get; set; }
        public int CantidadStock { get; set; }
        
        //No es necesario instanciar un objeto para realiar esta carga de trabajo,
        //recibe el listado sobre el cual trabajara
        public static Producto getProducto(string codigo, List<Producto> listado) {
            Producto encontrado = listado.Find(x => x.Codigo == codigo);
            return encontrado;
           
            
        }
        //Modifica la cantidad de un producto que ya ha sido agregado
        //anteriormente al stock del inventario actual
        public  void ModificarCantidad(int cant)
        {
            CantidadStock = CantidadStock + cant;
        }
    }
}
