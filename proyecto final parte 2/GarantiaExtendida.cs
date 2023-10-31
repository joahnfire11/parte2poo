// Decorador con función adicional de garantía extendida
public class GarantiaExtendida : DecoradorProductoTecnologico
{
    private double costoGarantia;

    public GarantiaExtendida(IProductoTecnologico producto, double costoGarantia)
        : base(producto)
    {
        this.costoGarantia = costoGarantia;
    }

    public override string ObtenerDescripcion()
    {
        return base.ObtenerDescripcion() + " + Garantía Extendida";
    }

    public override double ObtenerPrecio()
    {
        return base.ObtenerPrecio() + costoGarantia;
    }
}