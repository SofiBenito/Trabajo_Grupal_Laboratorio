using Biblioteca_clases.Dominio.Productos;
using System;

namespace Biblioteca_clases.Dominio.Facturas_Ordenes
{
    public class Autoplan
    {
        public int Id_Autoplan { get; set; }
        public double Tasa { get; set; }
        public DateTime Plazo { get; set; }
    }
}