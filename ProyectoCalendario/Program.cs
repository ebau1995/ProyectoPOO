using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCalendario
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            Menu();
        }
        static void Menu()
        {
            //Crear la instancia del calendario
            Calendario calendario= new Calendario();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Elige una opción");
                Console.WriteLine("[1] Mostrar calendario completo por año");
                Console.WriteLine("[2] Mostrar calendario completo por mes");
                Console.WriteLine("[3] Mostrar calendario completo por semana");
                Console.WriteLine("[4] Agendar un evento");
                Console.WriteLine("[5] Mostrar  evento agendado");
                Console.WriteLine("[6] Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":

                        calendario.MostrarPorAnio();
                        break;

                    case "2":

                        calendario.MostrarPorMes();
                        break;

                    case "3":

                       calendario. MostrarPorSemana();
                        break;

                    case "4":

                        calendario.AgendarEvento();
                        break;

                    case "5":

                        calendario.MostrarEvento();
                        Console.WriteLine($"Total de eventos agendados: {calendario.ContarEventos()}"); 
                        break;

                    case "6":
                        return;//se sale del programa

                    default:
                        Console.WriteLine("Opción no válida.Por favor, eliga 1, 2, 3, 4, 5, 6");
                        break;
                }
                Console.ReadLine();
            }
        }
        
       
           
    }
       
}
