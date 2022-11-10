using Biblioteca_clases.Dominio.Productos;

namespace Biblioteca_clases.Dominio.Facturas_Ordenes.T_Detalles
{
    public class Detalle_Orden
    {
        public int Id_Detalle_Orden { get; set; }
        public int Cantidad { get; set; }
        public double Precio_Unitario { get; set; }
        public Orden_Pedido Orden_Pedido { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Autoparte Autoparte { get; set; }
    }
}