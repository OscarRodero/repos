using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola{
    public class Ejercicio1
    {
        public static void Menu(){
            try
            {
                Console.WriteLine("¿Que deseas hacer?");
                Console.WriteLine("1.Visualizar día de la semana");
                Console.WriteLine("2.Incrementar una fecha");
                Console.WriteLine("3.Ver distancia entre fechas");
                Console.WriteLine("4.Comparar fechas");
                Console.WriteLine("5.Mostrar Fecha (formato largo)");
                int x = 0;
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        diaSemana();
                        break;
                    case 2:
                        IncrementarDia();
                        break;
                    case 3:
                        VerDistancia();
                        break;

                    case 4:
                        CompararFechas();
                        break;

                    case 5:
                        MostrarFechaLarga();
                        break;

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void MostrarFechaLarga()
        {
            Console.WriteLine("Dame la fecha");
            DateOnly x = new DateOnly();
            Boolean a = DateOnly.TryParse(Console.ReadLine(), out x);
        }

        public static void CompararFechas()
        {
            try
            {
                Console.WriteLine("Dame dos fechas");
                Console.WriteLine("Primera fecha:");
                DateOnly a = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("Segunda fecha:");
                DateOnly b = DateOnly.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine("La primera fecha es mayor que la segunda");
                }
                else if (a < b)
                {
                    Console.WriteLine("La segunda fecha es mayor que la primera");
                }
                else
                {
                    Console.WriteLine("Ambas son la misma fecha");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static void VerDistancia()
        {
            try
            {
                Console.WriteLine("Para ver cuanto se llevan necesito dos fechas: ");
                Console.WriteLine("Primera fecha:");
                DateOnly a = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("Segunda fecha:");
                DateOnly b = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("Años: " + Math.Abs(a.Year - b.Year));
                Console.WriteLine("Meses: " + Math.Abs(a.Month - b.Month));
                Console.WriteLine("Dias: " + Math.Abs(a.Day - b.Day));

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static void IncrementarDia()
        {
            try
            {
                Console.WriteLine("Dame una fecha");
                DateOnly x = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("¿Cuántos días quieres incrementarla?");
                int y = int.Parse(Console.ReadLine());
                x.AddDays(y);
                Console.WriteLine("La fecha ahora es: " + x);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        public static void diaSemana()
        {
            try
            {
                String FechaIntroducidad = new string(Console.ReadLine());
                DateOnly x = DateOnly.Parse(FechaIntroducidad);
                Console.WriteLine(x.ToString());
                switch (x.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        Console.WriteLine("Domingo");
                        break;
                    case DayOfWeek.Monday:
                        Console.WriteLine("Lunes");
                        break;
                    case DayOfWeek.Tuesday:
                        Console.WriteLine("Martes");
                        break;
                    case DayOfWeek.Wednesday:
                        Console.WriteLine("Miércoles");
                        break;
                    case DayOfWeek.Thursday:
                        Console.WriteLine("Jueves");
                        break;
                    case DayOfWeek.Friday:
                        Console.WriteLine("Viernes");
                        break;
                    case DayOfWeek.Saturday:
                        Console.WriteLine("Sábado");
                        break;
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
