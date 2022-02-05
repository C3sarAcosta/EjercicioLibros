using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLibros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------AUTOR 1 ----------------------
            Autores autor1 = new Autores(pNombre: "Adán", pApellidoPaterno: "Acosta", pApellidoMaterno: "Armendáriz", pSexo: "Masculino", pEdad: 15);

            autor1.PublicarLibro(nombreLibro : "Enseñando C#", categoria : "Programacion");

            //---------------------AUTOR 2------------------------
            Autores autor2 = new Autores("Blanca", "Lopez", "Dominguez", "Femenino", 18);
            autor2.PublicarLibro("El arte de dibujar", "Aprendizaje");

            //---------------------LIBRO 1------------------------
            Libros libro1 = new Libros("El arte de dibujar", "Delicias editorial", 185.23);
            string fechaPresentacion = libro1.PresentarLibro();
            Console.WriteLine(fechaPresentacion);

            libro1.VenderLibro(150);

            Console.ReadKey();
        }
    }
}
