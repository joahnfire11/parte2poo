// Clase base para productos tecnológicos
public class ProductoTecnologico : IProductoTecnologico
{
    private string descripcion;
    private double precio;

    public ProductoTecnologico(string descripcion, double precio)
    {
        this.descripcion = descripcion;
        this.precio = precio;
    }

    public string ObtenerDescripcion()
    {
        return descripcion;
    }

    public double ObtenerPrecio()
    {
        return precio;
    }
}