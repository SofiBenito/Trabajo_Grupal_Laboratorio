using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_clases.Dominio.Sesiones
{
    public class Usuario
    {
        public int Id_Sesion { get; set; }
        public string pUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Tipo_Usuario { get; set; }    
    }
}
