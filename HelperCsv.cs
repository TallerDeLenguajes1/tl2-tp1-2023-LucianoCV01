using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using EspacioCadeteria;
using EspacioCadete;

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
        public List<Cadete> ConversorDeCadete(List<string[]> Filas)
        {

            List<Cadete> MisCadetes = new List<Cadete>();
            foreach (string[] filas in Filas)
            {
                Cadete cad = new Cadete(int.Parse(filas[0]), filas[1], filas[2], filas[3]);
                MisCadetes.Add(cad);
            }
            return MisCadetes;
        }
        public Cadeteria ConversorDeCadeteria(List<string[]> Filas, List<Cadete> listadoCadetes)
        {

            Cadeteria? MiCadeteria = null;
            foreach (string[] filas in Filas)
            {
                MiCadeteria = new Cadeteria(filas[0], filas[1], listadoCadetes);
            }
            if (MiCadeteria != null)
            {
                return MiCadeteria;
            } else
            {
                return MiCadeteria = new("", "0", null);
            }
        }
    }
}