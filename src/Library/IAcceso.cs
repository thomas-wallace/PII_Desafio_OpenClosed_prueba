using System;

namespace Ucu.Poo.Ocp
{
    public interface IAcceso
    {
        bool EsValido(Membership membership, DateTime date, int hour);
    }
}