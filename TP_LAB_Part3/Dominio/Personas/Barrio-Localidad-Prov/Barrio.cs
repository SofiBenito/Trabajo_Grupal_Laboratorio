namespace Biblioteca_clases.Dominio.Personas
{
    public class Barrio
    {
        public int Id_barrio { get; set; }
        public string Nombre { get; set; }
        public Localidad Localidad { get; set; }
    }
}