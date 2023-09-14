using EspacioCadeteria;
using EspacioCadete;
using EspacioPedido;
using LectorCSV;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        const string archivoCadeteria = "Cadeteria.csv";
        const string archivoCadetes = "Cadetes.csv";
        const string rutaDeArchivo = "/Users/lucianocosentino/Documents/Repositorios/TallerII/tl2-tp1-2023-LucianoCV01/";
        HelperCsv help = new();
        List<string[]> LecturaDeCadetes = help.LeerCsv(rutaDeArchivo, archivoCadetes, ',');
        List<Cadete> MisCadetes = help.ConversorDeCadete(LecturaDeCadetes);  
        List<string[]> LecturaDeCadeteria = help.LeerCsv(rutaDeArchivo, archivoCadeteria, ',');
        Cadeteria cadeteria = help.ConversorDeCadeteria(LecturaDeCadeteria, MisCadetes);  

        string? opcion;
        do
        {
            Console.WriteLine("------ Menu ------");
            Console.WriteLine("1. Dar de Alta Pedido");
            Console.WriteLine("2. Asignar Pedido a Cadete");
            Console.WriteLine("3. Cambiar de Estado un Pedido");
            Console.WriteLine("4. Reasignar un Pedido a otro Cadete");
            Console.WriteLine("5. Mostrar Informe");
            Console.WriteLine("6. Salir");
            opcion = Console.ReadLine();
        } while (opcion != "6");
    }
}