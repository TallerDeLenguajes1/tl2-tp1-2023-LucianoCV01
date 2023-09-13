using EspacioPedido;
namespace EspacioCadete
{
    public class Cadete
    {
        public const int pagoPorPedido = 500;
        public const float error = -9999;
        // Atributos
        int id;
        string? nombre;
        string? direccion;
        string telefono;
        List<Pedido>? pedidos;

        // Propiedades
        public int Id { get => id; }
        public string? Nombre { get => nombre; }
        public string? Direccion { get => direccion; }
        public string Telefono { get => telefono; }
        public List<Pedido>? Pedidos { get => pedidos; set => pedidos = value; }

        // Constructores
        public Cadete(int id, string? nombre, string? direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            Pedidos = new();
        }

        //Metodos
        public float JornalACobrar(){
            if (pedidos != null)
            {
                var pedidosEntregados = pedidos.Where(p => p.Estado == Estado.Entregado);
                return pagoPorPedido * pedidosEntregados.Count();
            } else
            {
                return error;
            }
        }
        public void AgregarPedido(Pedido p){
            Pedidos?.Add(p);
        }
        // public Pedido BuscarPedido(int id){

        // }
    }
}