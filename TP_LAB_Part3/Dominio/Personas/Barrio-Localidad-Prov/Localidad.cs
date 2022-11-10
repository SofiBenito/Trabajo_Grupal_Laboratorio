namespace Biblioteca_clases.Dominio.Personas
{
    public class Localidad
    {
        public int Id_localidad { get; set; }
        public string Nombre { get; set; }
        public Provincia Provincia { get; set; }
    }
}