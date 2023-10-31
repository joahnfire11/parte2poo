// Decorador para productos tecnológicos que agrega funciones adicionales
public abstract class DecoradorProductoTecnologico: IProductoTecnologico
{
    protected IProductoTecnologico producto;

    public DecoradorProductoTecnologico(IProductoTecnologico producto)
    {
        this.producto = producto;
    }

    public virtual string ObtenerDescripcion()
    {
        return producto.ObtenerDescripcion();
    }

    public virtual double ObtenerPrecio()
    {
        return producto.ObtenerPrecio();
    }
}