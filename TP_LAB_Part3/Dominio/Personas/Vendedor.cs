using Biblioteca_clases.Dominio.Personas.Auxiliares;
using Biblioteca_clases.Dominio.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_clases.Dominio.Personas
{
    public class Vendedor
    {
        public int Id_vendedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public Barrio Id_barrio { get; set; }
        public Contacto Id_contacto { get; set; }
        public Tipo_Doc Id_tipo_doc { get; set; }
        public int Nro_doc { get; set; }
    }
}
