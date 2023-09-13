using EspacioPedido;
namespace EspacioCadete
{
    public class Cadete
    {
        public const int pagoPorPedido = 500;
        public const int error = -9999;
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
        public int EnviosEntregados(){
            int cantidadEnvios = error;
            if (pedidos != null)
            {
                var pedidosEntregados = pedidos.Where(p => p.Estado == Estado.Entregado);
                cantidadEnvios = pedidosEntregados.Count();
            }
            return cantidadEnvios;
        }
        public float JornalACobrar(){
            return pagoPorPedido * EnviosEntregados();
        }
        public void AgregarPedido(Pedido p){
            Pedidos?.Add(p);
        }
    }
}