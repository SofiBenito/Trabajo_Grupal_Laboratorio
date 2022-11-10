using Biblioteca_clases.Dominio.Personas.Auxiliares;
using Biblioteca_clases.Dominio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_clases.Dominio.Facturas_Ordenes
{
    public class Factura
    {
        public int Nro_factura { get; set; }
        public DateTime Fecha { get; set; }
        public Vendedor Id_vendedor { get; set; }
        public Cliente Id_Cliente { get; set; }
        public Forma_Entrega Forma_Entrega { get; set; }
        public Medio_Pedido Medio_Pedido { get; set; }
        public Forma_Pago Forma_Pago { get; set; }
        public Autoplan Autoplan { get; set; }
    }
}
