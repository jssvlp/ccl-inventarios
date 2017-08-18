using ccl.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccl.Test.Consol
{
    class Program
    {
        static Cliente cliente;
        static Colmado colmado;
        static Empleado empleado;
        static Inventario inventario;
        static List<Producto> listado;
        
        static Random random;

        public static void CrearColmado()
        {
            cliente = new Cliente("Juancito");

            colmado = new Colmado(cliente,100000);
            empleado = new Empleado("Felipe", 10500);
            colmado.SetEmpleado(empleado);
            colmado.Precio = 3500;
        }

        public static  void CrearProductos(int cantidad) {
            listado = new List<Producto>();
            random = new Random();
            
            Producto producto;
            for(int i = 1; i <= cantidad; i++)
            {
                producto = new Producto();
                producto.ID = random.Next(100);
                producto.Nombre = "Producto" + i.ToString();
                producto.Precio = random.Next(3000);
                producto.Codigo = (i * 100).ToString();
                producto.Medida = "Medida " + random.Next(5).ToString();
                listado.Add(producto);
            }

        }
        public static void AgregarProductos(int cantiProductos) {
            int c = cantiProductos;
            string codigo;
            string cantidad;
            Producto pro;
            int cantAumentar;
            try
            {
                while (c > 0)
                {
                    Console.Write("Codigo producto >>");
                    codigo = Console.ReadLine();
                    pro = Producto.getProducto(codigo, listado);
                    
                    if (pro == null)
                    {
                        Console.WriteLine("Producto no agregado, intente con otro codigo valido");
                        AgregarProductos(c);
                    }
                    Console.Write(pro.Nombre + "\tCantidad: ");
                    cantidad = Console.ReadLine();
                    //pro.CantidadStock = Int32.Parse(cantidad);
                    inventario.AgregarProducto(pro, Int32.Parse(cantidad));
                    c--;
                    

                
               
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void CrearInventario(int cantiProductos) {

            if (colmado != null)
            {
                inventario = new Inventario();
               
            }
            if (colmado.Inventarios != null)
            {
                if (colmado.Inventarios.Count == 0)
                    colmado.FechaPrimerInventario = DateTime.Now.Date;
            }

            AgregarProductos(cantiProductos);
                
            colmado.AddInventario(inventario);
            Console.WriteLine();
            Console.WriteLine("Nombre\t\tCantidad\tP. Unit\t\tSub");
            foreach (Producto pro in inventario.StockColmado)
            {
                Console.WriteLine(pro.Nombre + "\t"+ pro.CantidadStock + "\t\tRD$"+pro.Precio +"\t\tRD$"+pro.Precio * pro.CantidadStock );
            }
            Console.WriteLine();
            Console.WriteLine("Total Mercancia Vendida: RD$" + inventario.ContabilizarMercancia().ToString());
            


        }

        public static void  Programa() {
            Console.WriteLine("Bienvenido A Cecol Accounting System");
            Console.WriteLine("Cuantos productos deseas agregar >>");
            string cantidad = Console.ReadLine();
            CrearProductos(10);
            Console.WriteLine("Productos Creados");
            CrearColmado();
            Console.WriteLine("Colmado Creado");
            CrearInventario(Int32.Parse(cantidad));
            Console.WriteLine("*************************************************");
            Console.WriteLine(colmado.UltimoInventario.FechaInventario);
            Console.ReadKey();
            Console.Clear();
            //Console.WriteLine(colmado.UltimoInventario.FechaInventario);
           

            Console.ReadKey();



        }

        static void Main(string[] args)
        {

            Programa();

        }

       
    }
}
