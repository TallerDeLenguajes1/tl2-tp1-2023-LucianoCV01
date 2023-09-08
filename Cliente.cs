namespace EspacioCliente
{
    public class Cliente
    {
        // Atributos
        string? nombre;
        string? direccion;
        int telefono;
        string? datosReferenciaDireccion;

        //Propiedades
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string? DatosReferenciaDireccion { get => datosReferenciaDireccion; set => datosReferenciaDireccion = value; }
        
        // Constructores
        public Cliente()
        {
            Nombre = null;
            Direccion = null;
            Telefono = 0;
            DatosReferenciaDireccion = null;
        }
        public Cliente(string nombre, string direccion, int telefono, string datosReferenciaDireccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.DatosReferenciaDireccion = datosReferenciaDireccion;
        }
    }
}