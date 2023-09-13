using EspacioCadeteria; 
using EspacioCadete;
using EspacioPedido;
namespace EspacioInforme
{
    public class Informe
    {
        public string EnviosPorCadete(Cadete cad){
            return "Envios Entragados: " + cad.EnviosEntregados();
        }
        public string MontoGanadoPorCadete(Cadete cad){
            return "Monto ganado: " + cad.JornalACobrar();
        }
        public string PromedioEnviosPorCadete(List<Cadete> cadetes){
            float promedioEnvios;
            int enviosTotal = 0;
            foreach (var cadete in cadetes)
            {
                enviosTotal += cadete.EnviosEntregados();
            }
            promedioEnvios = cadetes.Count() / enviosTotal;
            return "Promedio envios por Cadete: " + promedioEnvios;
        }
        public string EnviosPorCadeteria(Cadeteria cadet){
            int enviosEntregados = -9999;
            if (cadet.Cadetes != null)
            {
                enviosEntregados = 0;
                foreach (var cad in cadet.Cadetes)
                {
                    enviosEntregados += cad.EnviosEntregados();
                }
            }
            return "Envios Entregados: " + enviosEntregados;
        }
        public string MontoGanadoPorCadeteria(Cadeteria cadet){
            float montoGanado = -9999;
            if (cadet.Cadetes != null)
            {
                foreach (var cad in cadet.Cadetes)
                {
                    montoGanado = 0;
                    montoGanado += cad.JornalACobrar();
                }
            }
            return "Monto ganado: " + montoGanado;
        }
    }
}