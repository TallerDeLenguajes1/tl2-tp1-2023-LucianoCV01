using EspacioCadeteria;
using EspacioCadete;
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
    }
}