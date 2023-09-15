using EspacioPedido;
namespace EspacioCadete
{
    public class Cadete
    {
        // Atributos
        int id;
        string? nombre;
        string? direccion;
        string telefono;

        // Propiedades
        public int Id { get => id; }
        public string? Nombre { get => nombre; }
        public string? Direccion { get => direccion; }
        public string Telefono { get => telefono; }

        // Constructores
        public Cadete(int id, string? nombre, string? direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        //Metodos


        // public void AgregarPedido(Pedido p){
        //     Pedidos?.Add(p);
        // }
    }
}