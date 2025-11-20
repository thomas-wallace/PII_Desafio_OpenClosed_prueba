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
                // Lunes a viernes 6am a 10am: Solo los usuarios que tengan membresía premium pueden ingresar
                new MananaPremium(),
                // Lunes a viernes 10am a 5pm: Pueden ingresar todos los usuarios con cualquier membresía
                new HorarioNormal(),
                //Sábados: Pueden ingresar todos los usuarios con cualquier membresía de 8am a 8pm.
                new Sabado(),
                
                //Lunes a viernes 5pm a 9pm: Sólo los usuarios con membresía básica o premium pueden ingresar, los pases por el día no
                new Tardes(),
                
                // Agrega una regla para que los feriados puedan ingresar los usuarios con membresía premium de 10am a 6pm.
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
