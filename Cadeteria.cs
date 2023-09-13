using EspacioCadete;
using EspacioPedido;
namespace EspacioCadeteria
{
    public class Cadeteria
    {
        // Atributos
        string? nombre;
        string telefono;
        List<Cadete>? cadetes;

        // Propiedades
        public string? Nombre { get => nombre; }
        public string Telefono { get => telefono; }
        internal List<Cadete>? Cadetes { get => cadetes; set => cadetes = value; }

        // Constructores
        public Cadeteria(string? nombre, string telefono, List<Cadete>? cadetes)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.cadetes = cadetes;
        }

        // // Metodos
        public Pedido DarAltaPedido(int numero, string observacion, Estado estado, string nombre, string direccion, int telefono, string datosReferenciaDireccion){
            Pedido pedidoNuevo = new(numero,observacion, estado, nombre, direccion, telefono, datosReferenciaDireccion);
            return pedidoNuevo;
        }
        public void AsignarPedidoACadete(int idCadete, Pedido nuevo)
        {
            if (Cadetes != null)
            {
                Cadete? encontrado = Cadetes.FirstOrDefault(c => c.Id == idCadete);
                
                if (encontrado != null)
                {                    
                    encontrado.AgregarPedido(nuevo);
                }
            }
        }
        public void CambiarEstadoDePedido(int numPedido, int idCadete, Estado estadoNuevo){
            if (Cadetes != null)
            {
                Cadete? encontrado = Cadetes.FirstOrDefault(c => c.Id == idCadete);
                if (encontrado != null)
                {                    
                    if (encontrado.Pedidos != null)
                    {
                        Pedido? pedEncontrado = encontrado.Pedidos.FirstOrDefault(p => p.Numero == numPedido);
                        if (pedEncontrado != null)
                        {
                            pedEncontrado.Estado = estadoNuevo;      
                        }
                    }
                }            
            }
        }
        public void ReasignarPedido(int idCadeteActual, int idCadeteNuevo, int numPedido){
            if (Cadetes != null)
            {
                Cadete? encontradoActual = Cadetes.FirstOrDefault(c => c.Id == idCadeteActual);
                Cadete? encontradoNuevo = Cadetes.FirstOrDefault(c => c.Id == idCadeteNuevo);
                if (encontradoActual != null && encontradoNuevo != null)
                {                    
                    if (encontradoActual.Pedidos != null && encontradoNuevo.Pedidos != null)
                    {
                        Pedido? pedEncontrado = encontradoActual.Pedidos.FirstOrDefault(p => p.Numero == numPedido);
                        if (pedEncontrado != null)
                        {
                            encontradoActual.Pedidos.Remove(pedEncontrado);  
                            encontradoNuevo.AgregarPedido(pedEncontrado);  
                        }
                    }
                }            
            }
        }
    }
}