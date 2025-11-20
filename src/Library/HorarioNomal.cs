using System;

namespace Ucu.Poo.Ocp
{
    public class HorarioNormal : IAcceso
    {
        public bool EsValido(Membership membership, DateTime date, int hour)
        {
            bool esDiaSemana = date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday;
            if (esDiaSemana && hour >= 10 && hour < 17)
            {
                return true;
            }
            return false;
        }
    }
}