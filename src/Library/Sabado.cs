using System;

namespace Ucu.Poo.Ocp
{
    public class Sabado : IAcceso
    {
        public bool EsValido(Membership membership, DateTime date, int hour)
        {
            bool esSabado = date.DayOfWeek  == DayOfWeek.Saturday;
            if (esSabado && hour >= 8 && hour < 20)
            {
                return true;
            }
            return false;
        }
    }
}