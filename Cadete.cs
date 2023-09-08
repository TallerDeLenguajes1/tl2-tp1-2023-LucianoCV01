using EspacioPedido;
namespace EspacioCadete
{
    class Cadete
    {
        public const int pagoPorPedido = 500;
        public const float error = -9999;
        // Atributos
        int id;
        string? nombre;
        string? direccion;
        int telefono;
        List<Pedido>? pedidos;

        // Propiedades
        public int Id { get => id; set => id = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Pedido>? Pedidos { get => pedidos; set => pedidos = value; }

        // Constructores
        public Cadete(){

        }
        public Cadete(int id, string? nombre, string? direccion, int telefono, List<Pedido> pedidos)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.pedidos = pedidos;
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
    }
}