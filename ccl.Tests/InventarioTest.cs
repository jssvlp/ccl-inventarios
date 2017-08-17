using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ccl.Negocio;
using System.Collections.Generic;

namespace ccl.Tests
{
    [TestClass]
    public class InventarioTest
    {
        Producto producto;
        List<Producto> Productos;
        Colmado colmado;
        Cliente cliente;
        Random random;


        [TestMethod]
        public void Inventario()
        {
            colmado.Id = 1000;
            cliente.Id = 23423;
            cliente.Nombre = "Perensejo";
            cliente.Apellidos = "Sustanejo";

            colmado.Propietario = cliente.Nombre + cliente.Apellidos;
            colmado.Nombre = "la creta";
            colmado.Direccion = "Camino chiquito";
            colmado.Telefono = "5555555";
            
            Inventario nuevo = new Inventario();
            foreach (Producto prod in Productos) {
                nuevo.AgregarProducto(prod);
                
            }
            nuevo.FinalizarInventario();
            colmado.AddInventario(nuevo);
            
            
             }

            private void Listar() {
                for (int i = 0; i < 10; i++) {
                producto.ID = i;
                producto.Nombre = "Producto 1";
                producto.Medida = "Unidades";
                producto.Precio = random.Next(500);
                Productos.Add(producto);
            }
        }
    }
}
