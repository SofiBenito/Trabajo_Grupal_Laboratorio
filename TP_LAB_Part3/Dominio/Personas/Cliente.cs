using Biblioteca_clases.Dominio.Personas.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_clases.Dominio.Personas
{
    public class Cliente
    {
        public int Id_cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public Tipo_Cliente Tipo_Cliente { get; set; }
        public Barrio Barrio { get; set; }
        public Contacto Contacto { get; set; }
        public Tipo_Doc Tipo_Doc { get; set; }
        public int Nro_doc { get; set; }
    }
}
