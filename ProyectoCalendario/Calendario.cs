using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProyectoCalendario
{
    public class Calendario
    {
        
        private List<Evento> eventos; // Lista de eventos
        private Feriado feriado;// instancia de la clase Feriado
        public int Anio {  get; set; }
        public Calendario()

        {
            Anio = Anio;
            eventos = new List<Evento>();//se inicializa la lista de eventos
            feriado= new Feriado();// se inicializa la clase feriados
        }

        public void MostrarPorAnio()
        {
            //Se crea la variable para guardar el valor del año requeriod
            int anio;
                
                    // Se le solicita que ingrese el año al usuario.
                    Console.WriteLine("Ingrese el año a consultar");
                    while(!int.TryParse(Console.ReadLine(), out anio)|| anio<= 0)
                    {
                        //Si el usuario no usa el formato solicitado se muestra el mensaje
                        Console.WriteLine("Por favor ingrese un año válido. Intentelo de nuevo");
                    }
            
            
                
                

            



            // Nombre de los días de la semana
            string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo","    Días feriados se señalan con *" };
            //Ancho de las columnas
            int anchoColumna = 10;
            
            
                for (int mes = 1; mes <= 12; mes++)
                {
                    // Obtener el número de días que tiene el mes
                    int diasEnElMes = DateTime.DaysInMonth(anio, mes);

                    //Mostrar el nombre del mes

                    Console.WriteLine($"\nMes:{new DateTime(anio, mes, 1).ToString("MMMM yyyy")}\n");
                    //Imprimir los encabezados de los días de la semana con el ancho de columna
                    foreach (string dia in diasSemana)
                    {
                        Console.Write(dia.PadRight(anchoColumna));

                    }
                    Console.WriteLine();
                    //Obtener el primer día de la semana del mes
                    DateTime primerDiaMes = new DateTime(anio, mes, 1);
                    //Ajuste para que el primer día sea lunes 1 y  domingo 7
                    int diaDeLaSemana = ((int)primerDiaMes.DayOfWeek == 0) ? 7 : (int)primerDiaMes.DayOfWeek;
                    // Imprimir espacios antes del primer día del mes
                    for (int i = 1; i < diaDeLaSemana; i++)
                    {
                        Console.Write("".PadRight(anchoColumna));
                    }
                    //Imprimir días de la semana
                    for (int dia = 1; dia <= diasEnElMes; dia++)
                    {
                        //Comprobar si es feriado
                        if (feriado.EsFeriado(new DateTime(anio, mes, dia)))
                        {
                            Console.Write($"{dia}*".PadRight(anchoColumna));
                        }
                        else
                        {
                            Console.Write(dia.ToString().PadRight(anchoColumna));
                        }
                        //Cambiar la línea despues del domingo
                        if ((dia + diaDeLaSemana - 1) % 7 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine("\n");//Salto de línea después de cada mes

                }
            
          

            Console.ReadLine();




        }
        public void MostrarPorMes()
        {

            //Se crea la variable para guardar el valor del año y el mes requerido
            int anio = 0;
            int mes = 0;
            Console.WriteLine("Ingrese el año a consultar");
            while (!int.TryParse(Console.ReadLine(), out anio) || anio <= 0)
            {
                //Si el usuario no usa el formato solicitado se muestra el mensaje
                Console.WriteLine("Por favor ingrese un año válido. Intentelo de nuevo");
            }

            // Nombre de los días de la semana
            string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo", "    Días feriados se señalan con *" };
            //Ancho de las columnas
            int anchoColumna = 10;

            
                
           // Se le solicita el mes al usuario
           Console.WriteLine("Ingrese el mes a consultar");
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                //Si el mes que ingresa no cumple el formato o se pasa del 12 el sistema le indica que hubo error y le pide que lo vuelva a ingresar.
                Console.WriteLine("Error: El mes debe estar entre 1 a 12. Intentelo de nuevo");
                Console.WriteLine("Ingrese un número entero valido para el mes");
            }  
            

            // Obtener el número de días que tiene el mes
            int diasEnElMes = DateTime.DaysInMonth(anio, mes);

            //Mostrar el nombre del mes

            Console.WriteLine($"\nMes:{new DateTime(anio, mes, 1).ToString("MMMM yyyy")}\n");
            //Imprimir los encabezados de los días de la semana con el ancho de columna
            foreach (string dia in diasSemana)
            {
                Console.Write(dia.PadRight(anchoColumna));

            }
            Console.WriteLine();
            //Obtener el primer día de la semana del mes
            DateTime primerDiaMes = new DateTime(anio, mes, 1);
            //Ajuste para que el primer día sea lunes 1 y  domingo 7
            int diaDeLaSemana = ((int)primerDiaMes.DayOfWeek == 0) ? 7 : (int)primerDiaMes.DayOfWeek;
            // Imprimir espacios antes del primer día del mes
            for (int i = 1; i < diaDeLaSemana; i++)
            {
                Console.Write("".PadRight(anchoColumna));
            }
            //Imprimir días de la semana
            for (int dia = 1; dia <= diasEnElMes; dia++)
            {

                //Comprobar si es feriado
                if (feriado.EsFeriado(new DateTime(anio, mes, dia)))
                {
                    Console.Write($"{dia}*".PadRight(anchoColumna));
                }
                else
                {
                    Console.Write(dia.ToString().PadRight(anchoColumna));
                }
                //Cambiar la línea despues del domingo
                if ((dia + diaDeLaSemana - 1) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");//Salto de línea después de cada mes

            Console.ReadLine();

        }
        public void MostrarPorSemana()
        {
            //Se crea la variable para guardar el valor del año y el mes requerido
            int anio = 0;
            int mes = 0;
            int numeroSemana = 0;
            Console.WriteLine("Ingrese el año a consultar");
            while (!int.TryParse(Console.ReadLine(), out anio) || anio <= 0)
            {
                //Si el usuario no usa el formato solicitado se muestra el mensaje.
                Console.WriteLine("Por favor ingrese un año válido. Intentelo de nuevo");
            }

            // Nombre de los días de la semana
            string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo", "    Días feriados se señalan con *" };
            //Ancho de las columnas
            int anchoColumna = 10;



            // Se le solicita el mes al usuario
            Console.WriteLine("Ingrese el mes a consultar");
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                //Si el mes que ingresa no cumple el formato o se pasa del 12 el sistema le indica que hubo error y le pide que lo vuelva a ingresar.
                Console.WriteLine("Error: El mes debe estar entre 1 a 12. Intentelo de nuevo");
                Console.WriteLine("Ingrese un número entero valido para el mes");
            }

            //Se le solicita la semana al usuario
            Console.WriteLine("Ingrese el número de la  semana a consultar");
            while (!int.TryParse(Console.ReadLine(),out numeroSemana) || numeroSemana <= 0)
            {
                //Se muestra un error si la semana digitada no cumple las condiciones o es menor o igual a cero
                Console.WriteLine("Error: El número de semanas debe ser mayor que 0. Intentelo de nuevo");
            }

            // Obtener el número de días que tiene el mes
            int diasEnElMes = DateTime.DaysInMonth(anio, mes);

            //Mostrar el nombre del mes

            Console.WriteLine($"\nMes:{new DateTime(anio, mes, 1).ToString("MMMM yyyy")}\n");

            //Imprimir los encabezados de los días de la semana con el ancho de columna
            foreach (string dia in diasSemana)
            {
                Console.Write(dia.PadRight(anchoColumna));

            }
            Console.WriteLine();


            // Obtener el primer día de la semana del mes
            DateTime primerDiaMes = new DateTime(anio, mes, 1);


            //Ajuste para que el primer día sea lunes 1 y  domingo 7
            int diaDeLaSemana = ((int)primerDiaMes.DayOfWeek == 0) ? 7 : (int)primerDiaMes.DayOfWeek;

            int diaInicioSemana = (numeroSemana - 1) * 7 - (diaDeLaSemana - 1) + 1;
            int diaFinSemana = diaInicioSemana + 6;

            //Ajustar los límites de la semana en el caso de que el mes no empieza siempre en lunes

            if (diaInicioSemana < 1)
            {
                diaInicioSemana = 1;
            }

            if (diaFinSemana > diasEnElMes)
            {
                diaFinSemana = diasEnElMes;
            }
            //Imprimir espacios antes del primer día (si el mes no empieza en lunes)
            if (numeroSemana == 1)//Para la primera semana
            {
                for (int i = 1; i < diaDeLaSemana; i++)
                {
                    Console.Write("".PadRight(anchoColumna));
                }
            }

            //Imprimir días de la semana seleccionada con ancho fijo
            for (int dia = diaInicioSemana; dia <= diaFinSemana; dia++)
            {
                //Comprobar si es feriado
                if (feriado.EsFeriado(new DateTime(anio, mes, dia)))
                {
                    Console.Write($"{dia}*".PadRight(anchoColumna));
                }
                else
                {
                    Console.Write(dia.ToString().PadRight(anchoColumna));
                }

                //Cambio de línea despues del domingo
                if ((dia + diaDeLaSemana - 1) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadLine();


        }
        public void AgendarEvento()
        {
            
            DateTime fechaEvento;

            Console.WriteLine("Ingrese la fecha del evento en formato (mm/dd/yyyy): ");
               while (!DateTime.TryParse(Console.ReadLine(), out fechaEvento))
                {
                    //Se debe introducir un dormato especifico mes/día/años en ese orden de lo contrario
                    //el programa le pedira que ingrese el formato correcto.
                    Console.WriteLine("Formato de fecha incorrecto. Por favor, intente de nuevo.");
             
                }


            string descripcion;
            //La descripcion seguira pidiendo que ingrese la descripción hasta que deje de ser un valor vacío.
            do {
                Console.WriteLine("Ingrese la descripción del evento: ");
                descripcion = Console.ReadLine();
                if (descripcion =="")
                {
                    Console.WriteLine("Necesita ingresar una descripción para continuar");
                    
                }
            }while (descripcion == "");



            // Agregar el nuevo evento a la lista
            Evento nuevoEvento = new Evento(fechaEvento, descripcion);
            eventos.Add(nuevoEvento);
            Console.WriteLine("Evento agendado con éxito.");
        }
        

        // Contar la cantidad de eventos agendados
        public int ContarEventos()
        {
            return eventos.Count;

        }
        public void MostrarEvento()
        {
            if (eventos.Count==0)
            {
                Console.WriteLine("No hay eventos agendados.");
            }
            else
            {
                Console.WriteLine("Eventos agendados:");
                foreach(var evento in eventos)
                {
                    evento.MostrarEvento();
                }
            }
        }
        
    }
}
