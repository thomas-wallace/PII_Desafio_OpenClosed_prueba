using System;

namespace Ucu.Poo.Ocp
{
    public class MananaPremium : IAcceso
    {
        public bool EsValido(Membership membership, DateTime date, int hour)
        {
            bool esDiaSemana = date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday;
            bool esHorarioManana = hour >= 6 && hour < 10;

            if (esDiaSemana && esHorarioManana && membership == Membership.Premium)
            {
                return true;
            }
            return false;
        }
    }
}