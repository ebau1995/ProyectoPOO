using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCalendario
{
    public class Evento
    {
       
        
        public DateTime FechaEvento { get; set; }
        public string Descripcion { get; set; }

        public Evento(DateTime fechaEvento, string descripcion)
        {
            this.FechaEvento = fechaEvento;
            this.Descripcion = descripcion;
        }
       
        public void MostrarEvento()
        {
            Console.WriteLine($"Evento:{Descripcion} en {FechaEvento.ToShortDateString()}");
        }
       
       


    }
}
