using System;

namespace Ucu.Poo.Ocp
{
    public class Tardes : IAcceso
    {
        public bool EsValido(Membership membership, DateTime date, int hour)
        {
            bool esDiaSemana = date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday;
            bool esHorarioManana = hour >= 17 && hour < 21;

            if (esDiaSemana && esHorarioManana && membership != Membership.DayPass)
            {
                return true;
            }
            return false;
        }
    }
}