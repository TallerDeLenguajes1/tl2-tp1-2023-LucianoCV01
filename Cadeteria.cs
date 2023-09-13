using EspacioCadete;
namespace EspacioCadeteria
{
    public class Cadeteria
    {
        // Atributos
        string? nombre;
        string telefono;
        List<Cadete>? cadetes;

        // Propiedades
        public string? Nombre { get => nombre; }
        public string Telefono { get => telefono; }
        internal List<Cadete>? Cadetes { get => cadetes; set => cadetes = value; }

        // Constructores
        public Cadeteria(string? nombre, string telefono, List<Cadete>? cadetes)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.cadetes = cadetes;
        }

        // Metodos

    }
}