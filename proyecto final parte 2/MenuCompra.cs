// Clase que representa el menú de compra
using System;
using System.Collections.Generic;
using System.IO;
public class MenuCompra
{
    private List<string> opciones;
    private List<IProductoTecnologico> productos;

    public MenuCompra()
    {
        opciones = new List<string>();
        productos = new List<IProductoTecnologico>();
    }

    public void AgregarOpcion(string opcion)
    {
        opciones.Add(opcion);
    }

    public void MostrarMenu()
    {
        Console.WriteLine("----- MENÚ DE COMPRA -----");
        for (int i = 0; i < opciones.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {opciones[i]}");
        }
        Console.WriteLine("--------------------------");
    }

    public void AgregarProducto(IProductoTecnologico producto)
    {
        productos.Add(producto);
    }

    public void MostrarProductos()
    {
        Console.WriteLine("Productos seleccionados:");
        foreach (var producto in productos)
        {
            Console.WriteLine($"- {producto.ObtenerDescripcion()} - Precio: {producto.ObtenerPrecio()}");
        }
    }

    public void RealizarCompra()
    {
        MostrarMenu();
        Console.WriteLine("Seleccione una opción (1 - {0}):", opciones.Count);
        int opcionSeleccionada;
        while (!int.TryParse(Console.ReadLine(), out opcionSeleccionada) || opcionSeleccionada < 1 || opcionSeleccionada > opciones.Count)
        {
            Console.WriteLine("Opción inválida. Intente nuevamente:");
        }

        Console.WriteLine("Has seleccionado la opción: {0}", opciones[opcionSeleccionada - 1]);
        Console.WriteLine("¡Gracias por su compra!");
    }

    public List<IProductoTecnologico> ObtenerProductos()
    {
        return productos;
    }
}