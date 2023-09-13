using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LectorCSV
{
    public class HelperCsv
    {
        public List<string[]> LeerCsv(string rutaDeArchivo, string nombreDeArchivo, char caracter)
        {
            FileStream MiArchivo = new FileStream(rutaDeArchivo + nombreDeArchivo, FileMode.Open);
            StreamReader StrReader = new StreamReader(MiArchivo);

            string? Linea = "";
            List<string[]> LecturaDelArchivo = new List<string[]>();

            while ((Linea = StrReader.ReadLine()) != null)
            {
                string[] Fila = Linea.Split(caracter);
                LecturaDelArchivo.Add(Fila);
            }

            return LecturaDelArchivo;
        }

    }
}