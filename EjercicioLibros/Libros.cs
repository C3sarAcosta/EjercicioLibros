using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLibros
{
    internal class Libros
    {
        public string Nombre { get; set; }
        public string Editorial { get; set; }
        public double Precio { get; set; }

        public Libros(string pNombre, string pEditorial, double precio)
        {
            Nombre = pNombre;
            Editorial = pEditorial;
            Precio = precio;
        }

        public void VenderLibro(int cantidad)
        {
            Console.WriteLine("Vendi " + cantidad + " Libros");
        }

        public string PresentarLibro()
        {
            return DateTime.Now.ToString();
        }
    }
}
