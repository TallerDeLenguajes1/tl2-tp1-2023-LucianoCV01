using EspacioCadete;
using EspacioPedido;
namespace EspacioCadeteria
{
    public class Cadeteria
    {
        public const int pagoPorPedido = 500;
        public const int error = -9999;
        // Atributos
        string? nombre;
        string telefono;
        List<Cadete>? cadetes;
        List<Pedido>? pedidos;

        // Propiedades
        public string? Nombre { get => nombre; }
        public string Telefono { get => telefono; }
        internal List<Cadete>? Cadetes { get => cadetes; set => cadetes = value; }
        public List<Pedido>? Pedidos { get => pedidos; set => pedidos = value; }

        // Constructores
        public Cadeteria(string? nombre, string telefono, List<Cadete>? cadetes)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.cadetes = cadetes;
        }

        // // Metodos
        public Pedido DarAltaPedido(int numero, string observacion, Estado estado, Cadete? cadete , string nombre, string direccion, int telefono, string datosReferenciaDireccion){
            Pedido pedidoNuevo = new(numero,observacion, estado, cadete, nombre, direccion, telefono, datosReferenciaDireccion);
            return pedidoNuevo;
        }
        public int EnviosEntregadosPorCadete(int idCadete){
            int cantidadEnvios = error;
            if (pedidos != null)
            {
                var pedidosEntregados = pedidos.Where(p => p.Estado == Estado.Entregado);
                var pedidosCadete = pedidosEntregados.Where(p => p.Cadete.Id == idCadete);
                cantidadEnvios = pedidosCadete.Count();
            }
            return cantidadEnvios;
        }
        public float JornalACobrar(int idCadete){
            float monto = error;
            if (Cadetes != null)
            {
                monto =  pagoPorPedido * EnviosEntregadosPorCadete(idCadete);
            }
            return monto;
        }
        public void AsignarCadeteAPedido(int idCadete, int idPedido){
            Cadete? encontrado = Cadetes.FirstOrDefault(c => c.Id == idCadete);
            Pedido? buscado = Pedidos.FirstOrDefault(p => p.Numero == idPedido);
            buscado.Cadete = encontrado;
        }

        // public void CambiarEstadoDePedido(int numPedido, int idCadete, Estado estadoNuevo){
        //     if (Cadetes != null)
        //     {
        //         Cadete? encontrado = Cadetes.FirstOrDefault(c => c.Id == idCadete);
        //         if (encontrado != null)
        //         {                    
        //             if (encontrado.Pedidos != null)
        //             {
        //                 Pedido? pedEncontrado = encontrado.Pedidos.FirstOrDefault(p => p.Numero == numPedido);
        //                 if (pedEncontrado != null)
        //                 {
        //                     pedEncontrado.Estado = estadoNuevo;      
        //                 }
        //             }
        //         }            
        //     }
        // }
        // public void ReasignarPedido(int idCadeteActual, int idCadeteNuevo, int numPedido){
        //     if (Cadetes != null)
        //     {
        //         Cadete? encontradoActual = Cadetes.FirstOrDefault(c => c.Id == idCadeteActual);
        //         Cadete? encontradoNuevo = Cadetes.FirstOrDefault(c => c.Id == idCadeteNuevo);
        //         if (encontradoActual != null && encontradoNuevo != null)
        //         {                    
        //             if (encontradoActual.Pedidos != null && encontradoNuevo.Pedidos != null)
        //             {
        //                 Pedido? pedEncontrado = encontradoActual.Pedidos.FirstOrDefault(p => p.Numero == numPedido);
        //                 if (pedEncontrado != null)
        //                 {
        //                     encontradoActual.Pedidos.Remove(pedEncontrado);  
        //                     encontradoNuevo.AgregarPedido(pedEncontrado);  
        //                 }
        //             }
        //         }            
        //     }
        // }
    }
}