using Biblioteca_clases.Dominio.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_clases.Dominio.Facturas_Ordenes.T_Detalles
{
    public class Detalles_Factura
    {
        public int Id_Detalle_Factura { get; set; }
        public int Cantidad { get; set; }
        public double Precio_Unitario { get; set; }
        public Factura pFactura { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Autoparte Autoparte { get; set; }
        public Autoplan Autoplan { get; set; }
        public Detalle_Orden Detalle_Orden { get; set; }
        public double Descuento { get; set; }
    }
}
