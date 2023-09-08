using EspacioCliente;
namespace EspacioPedido
{
    public class Pedido
    {
        // Atributos
        int numero;
        string? observacion;
        Cliente? cliente = new();
        Estado estado;

        // Propiedades
        public int Numero { get => numero; set => numero = value; }
        public string? Observacion { get => observacion; set => observacion = value; }
        //public Cliente? Cliente { get => cliente; set => cliente = value; }  // Porque no debo usar propiedad para esto, rompe encapsulamiento porque se esta accediendo a la referencia 
        internal Estado Estado { get => estado; set => estado = value; }

        // Constructores
        public Pedido() // El constructor puede ser vacio o hay que inicializarlo?
        {

        }
        public Pedido(int numero, string observacion, Estado estado)
        {
            this.numero = numero;
            this.observacion = observacion;
            this.estado = estado;
        }
        /*
        Para que se produzca la relacion de composicion entre cliente y pedido, 
        tendria que instanciar pedido en el constructor o en el atributo?
        Y como le doy valor a cliente por metodo o pasandolo por el constructor?
        */

        // Metodos
        public void AgregarCliente(Cliente c){
            cliente = c;
        }
        public void EliminarCliente(){
            cliente = null;
        }
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