using System;
using System.Collections.Generic;
using System.IO;
public class Program
{
    public static void Main(string[] args)
    {
        // Crear productos tecnológicos
        IProductoTecnologico celular = new ProductoTecnologico("Celular", 1000);
        IProductoTecnologico laptop = new ProductoTecnologico("Laptop", 2000);

        // Agregar garantía extendida a algunos productos
        celular = new GarantiaExtendida(celular, 100);
        laptop = new GarantiaExtendida(laptop, 200);

        // Crear menú de compra
        MenuCompra menuCompra = new MenuCompra();

        // Agregar productos al menú
        menuCompra.AgregarProducto(celular);
        menuCompra.AgregarProducto(laptop);

        // Mostrar productos seleccionados
        menuCompra.MostrarProductos();

        // Mostrar el total de la compra
        Console.WriteLine("Total de la compra: $" + ObtenerTotalCompra(menuCompra));

        // Agradecer por la compra
        MostrarMensajeAgradecimiento();

        Console.ReadLine();
    }

    public static double ObtenerTotalCompra(MenuCompra menuCompra)
    {
        double total = 0;

        foreach (var producto in menuCompra.ObtenerProductos())
        {
            total += producto.ObtenerPrecio();
        }

        return total;
    }

    public static void MostrarMensajeAgradecimiento()
    {
        Console.WriteLine("Gracias por su compra");
    }
}