using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_clases.Dominio.Productos
{
    public class Vehiculo
    {
        public int Id_vehiculo { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public double Precio_Unitario { get; set; }
        public int Stock { get; set; }
    }
}
