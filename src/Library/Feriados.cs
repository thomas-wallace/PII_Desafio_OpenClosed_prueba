using System;

namespace Ucu.Poo.Ocp
{
    public class Feriados : IAcceso
    {
            public bool EsValido(Membership membership, DateTime date, int hour)
            {
                bool esFeriado = Calendar.IsHoliday(date);
                if (esFeriado && hour >= 10 && hour <= 18 && membership == Membership.Premium)
                {
                    return true;
                }
                return false;
            
        }
    }
}