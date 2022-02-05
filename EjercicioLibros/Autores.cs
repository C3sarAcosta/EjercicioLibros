using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLibros
{
    internal class Autores
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }

        public Autores(string pNombre, string pApellidoPaterno, string pApellidoMaterno, string pSexo, int pEdad)         
        {
            Nombre = pNombre;
            ApellidoPaterno = pApellidoPaterno;
            ApellidoMaterno = pApellidoMaterno;
            Sexo = pSexo;
            Edad = pEdad;
        }

        public void PublicarLibro(string nombreLibro, string categoria)
        {
            Console.WriteLine(Nombre + " publicó su libro " + nombreLibro + " en la categoria " + categoria);
        }
    }
}
