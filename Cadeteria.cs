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
        public string? Nombre { get => nombre; }
        public int Telefono { get => telefono; }
        internal List<Cadete>? Cadetes { get => cadetes; set => cadetes = value; }

        // Constructores
        public Cadeteria(string? nombre, int telefono, List<Cadete>? cadetes)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.cadetes = cadetes;
        }

        // Metodos
        public Cadeteria ConversorDeCadeteria(List<string[]> Filas, List<Cadete> listadoCadetes)
        {

            Cadeteria MiCadeteria = new ();
            foreach (string[] filas in Filas)
            {
                Cadeteria cad = new Cadeteria(filas[0], Convert.ToInt32(filas[1]), listadoCadetes);
            }
            return MiCadeteria;
        }
    }
}