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
        public int Id { get => id; }
        public string? Nombre { get => nombre; }
        public string? Direccion { get => direccion; }
        public int Telefono { get => telefono; }
        public List<Pedido>? Pedidos { get => pedidos; set => pedidos = value; }

        // Constructores
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
        public List<Cadete> ConversorDeCadete(List<string[]> Filas,List<Pedido> pedidos)
        {

            List<Cadete> MisCadetes = new List<Cadete>();
            foreach (string[] filas in Filas)
            {
                Cadete cad = new Cadete(Convert.ToInt32(filas[0]), filas[1], filas[2],Convert.ToInt32(filas[3]), pedidos);
                MisCadetes.Add(cad);
            }
            return MisCadetes;

        }
    }
}