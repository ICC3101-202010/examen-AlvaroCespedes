using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Alvaro_Cespedes
{
    public class Equipo
    {
        private List<Jugador> jugadores;
        private bool tipoEquipo;
        private string medico;
        private string entrenador;

        public Equipo()
        {

        }

        public Equipo(List<Jugador> jugadores, bool tipoEquipo, string medico, string entrenador)
        {
            this.Jugadores = jugadores;
            this.TipoEquipo = tipoEquipo;
            this.Medico = medico;
            this.Entrenador = entrenador;
        }

        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public bool TipoEquipo { get => tipoEquipo; set => tipoEquipo = value; }
        public string Medico { get => medico; set => medico = value; }
        public string Entrenador { get => entrenador; set => entrenador = value; }

        public bool CorroborarNacionalidad(Jugador jugador, List<Jugador> jugadores)
        {
            string nacionalidad = "";
            int contador = 0;
            foreach (Jugador x in jugadores)
            {
                if(contador == 0)
                {
                    nacionalidad = x.Nacionalidad;
                    contador++;
                }
                else
                {
                    if(nacionalidad != x.Nacionalidad)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public override string ToString()
        {
            string var1 = "";
            var1 += "jugadores: ";
            foreach(Jugador x in Jugadores)
            {
                var1 += x.Nombre;
                var1 += ", ";
            }
            if(TipoEquipo)
            {
                var1 += ". Tipo de equipo:  ";
                var1 += "Nacional";
                var1 += ". ";
                var1 += "Medico: ";
                var1 += Medico;
                var1 += ". ";
                var1 += "Entrenador: ";
                var1 += ". ";
                var1 += Entrenador;
            }
            else
            {
                var1 += ". Tipo de equipo:  ";
                var1 += "Liga";
                var1 += ". ";
                var1 += "Medico: ";
                var1 += Medico;
                var1 += ". ";
                var1 += "Entrenador: ";
                var1 += ". ";
                var1 += Entrenador;
            }
            return var1;
        }
    }
}
