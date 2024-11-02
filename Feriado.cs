using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCalendario
{
    public class Feriado
    {
       
        private List<(int Mes, int Dia)> feriado;//Lista de mes y día de los feriados

        public Feriado()
        {
            //Se inicializa la lista de dias feriados
            feriado = new List<(int Mes, int Dia)>
            {
                (1,1),
                (4,11),
                (5,1),
                (7,25),
                (8,2),
                (8,15),
                (8,31),
                (9,15),
                (12,1),
                (12,25),
            };
        }
        //Método para verificar fechas que tengan feriadp
        public bool EsFeriado (DateTime fecha)
        {
            return feriado.Contains((fecha.Month,fecha.Day));

        }
        //Método para agregar a la lista de feriados
        public void AgregarFeriado(int mes, int dia)
        {
            if(!feriado.Contains((mes,dia)))
                {
                feriado.Add((mes,dia));
            }
        }
        public List<(int Mes, int Dia)> ObtenerFeriados()
        {
            return feriado;
        }
    }
}
