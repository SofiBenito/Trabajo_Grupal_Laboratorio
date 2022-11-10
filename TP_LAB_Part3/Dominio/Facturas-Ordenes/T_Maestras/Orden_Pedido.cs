using Biblioteca_clases.Dominio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_clases.Dominio.Facturas_Ordenes
{
    public class Orden_Pedido
    {
        public int Id_orden { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime MyProperty { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
    }
}
