using EspacioCadete;
namespace EspacioCadeteria
{
    class Cadeteria
    {
        // Atributos
        string? nombre;
        int telefono;
        List<Cadete>? cadetes;

        // Propiedades
        public string? Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        internal List<Cadete>? Cadetes { get => cadetes; set => cadetes = value; }

        // Constructores
        public Cadeteria(){

        }
        public Cadeteria(string? nombre, int telefono, List<Cadete>? cadetes)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.cadetes = cadetes;
        }

        // Metodos
        
    }
}