using System;
using System.Collections.Generic;

namespace Ucu.Poo.Ocp
{
    /// <summary>
    /// Esta clase representa un gimnasio con reglas de acceso basadas en el
    /// tipo de usuario, día de la semana y hora del día.
    /// </summary>
    public class Gym
    {
        private List<IAcceso> reglas;

        /// <summary>
        /// Determina si un usuario puede ingresar al gimnasio en un día y hora.
        /// </summary>
        /// <param name="membership"></param>
        /// <param name="date"></param>
        /// <param name="hour"></param>
        /// <returns></returns>
        ///

        public Gym()
        {


            reglas = new List<IAcceso>
            {
                new MananaPremium(),
                new HorarioNormal(),
                new Feriados(),
            };
        }

        public bool CanEnter(Membership membership, DateTime date, int hour)
            {
                foreach (var rule in this.reglas)
                {
                     if (rule.EsValido(membership, date, hour))
                    {
                        return true; 
                    }
                }

                return false; 
            }
        
    }
}
