using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccl.Negocio
{
    //Esta clase contiene todos los metodos, atributos y propiedades para crear un Inventario.
    public class Inventario
    {
        public int Id { get; set; }
        public string FechaInventario { get; set; }
        public  List<Producto> StockColmado;
        public Inventario UltimoInventario { get; set; }
        public float Capital { get; set; }
        public float ExistenciaMercancia { get; set; }
        public bool Finalizado { get; set; }

        //Constructor
        public  Inventario()
        {
            FechaInventario = DateTime.Now.ToString();
            StockColmado = new List<Producto>();
            Finalizado = false;
         }

        public Inventario GetInventario()
        {
            if (this.Finalizado)
                return this;
            return null;
        }

        //Finaliza el inventario, configura sus opciones y da paso a la Contabilidad
        public float FinalizarInventario(float CuentasPorCobrar)
        {
            //ContabilizarMercancia();
            Contabilidad contabilidad = new Contabilidad();
            contabilidad.ExistenciaMercancia = this.ExistenciaMercancia;
            contabilidad.CuentasPorCobrar = CuentasPorCobrar;
            UltimoInventario = this;
            Finalizado = true;
            return contabilidad.CalcularBeneficio();
            
        }
        //Suma las ventas equivalentes a cada producto
        public float ContabilizarMercancia() {
            foreach(Producto producto in StockColmado) {
                ExistenciaMercancia = ExistenciaMercancia + (producto.CantidadStock * producto.Precio);
            }
            return ExistenciaMercancia;
        }

        //Valida si un producto ya ha sido agregado al stock del inventario actual
        public bool ProductExistOnStock(string codigo) {
            if (StockColmado.Exists(x => x.Codigo == codigo))
                return true;
            return false;
        }

        /// Nunca agregar la cantidad de un producto X al stock antes de invocar el Metodo este metodo 
        /// (AgregarProducto) Si no lo recuerdas, te dio buena agua a beber.
        public void AgregarProducto(Producto producto, int cantidad) {
            //Primer producto del inventario
            if (StockColmado.Count == 0)
            {
                producto.CantidadStock = cantidad;
                StockColmado.Add(producto);
                Console.WriteLine("Agregado");
            }
            //Siguientes productos
            else
            {
                //Existe en el stock del inventario actual? Si, solo suma la cantidad que se digito a la que tenia
                if (ProductExistOnStock(producto.Codigo))
                {   //Expresion Lambda. 
                    StockColmado.Find(x => x.Codigo == producto.Codigo).ModificarCantidad(cantidad);   
                }
                //Si no existe lo agrega 
                else
                {
                    producto.CantidadStock = cantidad;
                    Console.WriteLine("Agregado");
                    StockColmado.Add(producto);
                }
                    
            }
        }

        //Remueve un producto del stock del inventarioActual
        public void QuitarProducto(Producto producto)
        {
            StockColmado.Remove(producto);
        }

        
        
        

    }
}
