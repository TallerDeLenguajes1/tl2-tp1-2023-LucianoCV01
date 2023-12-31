using EspacioCliente;
namespace EspacioPedido
{
    public class Pedido
    {
        // Atributos
        int numero;
        string? observacion;
        Cliente? cliente;
        Estado estado;

        // Propiedades
        public int Numero { get => numero; }
        public string? Observacion { get => observacion; set => observacion = value; }
        public Cliente? Cliente { get => cliente; }   
        internal Estado Estado { get => estado; set => estado = value; }

        // Constructores
        public Pedido(int numero, string observacion, Estado estado, string nombre, string direccion, int telefono, string datosReferenciaDireccion)
        {
            this.numero = numero;
            this.observacion = observacion;
            cliente = new(nombre, direccion, telefono, datosReferenciaDireccion);
            this.estado = estado;
        }

        // Metodos
        public string VerDireccionCliente(){
            if (cliente != null)
            {
                return cliente.Direccion + " - " + cliente.DatosReferenciaDireccion;
            } else
            {
                return "Error - Cliente es Null";
            }
        }
        public string VerDatosCliente(){
            if (cliente != null)
            {
                return cliente.Nombre + ", " + cliente.Telefono;
            } else
            {
                return "Error - Cliente es Null";
            }
        }
    }
    public enum Estado
    {
        Pendiente,
        Entregado,
        Cancelado,
    }
}