using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola
{
    internal class Ejercicio2
    {
        public static void Menu() {
            Boolean finPrograma=false;
            do {
                Console.WriteLine("¿Que deseas hacer?");
                Console.WriteLine("1. Insertar 1 libro nuevo");
                Console.WriteLine("2. Ver mi lista de libros");
                Console.WriteLine("3. Modificar un libro");
                Console.WriteLine("4. Borrar Libro");
                Console.WriteLine("5. Salir");
                int x;
                bool valido;
                valido = int.TryParse(Console.ReadLine(), out x);
                if (!valido||x<1||x>5) {
                    Console.WriteLine("Debe elegir una opción");
                }
                switch (x)
                {
                    case 1:
                        Ejercicio2.InsertarLibro();
                        break;
                    case 2:
                        Ejercicio2.Menu();
                        break;
                }
            } while (!finPrograma);
        
        }

        private static void InsertarLibro()
        {
            throw new NotImplementedException();
        }
    }
}
