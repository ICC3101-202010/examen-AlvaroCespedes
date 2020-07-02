using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Alvaro_Cespedes
{
    public class Jugador
    {
        private string nombre;
        private string nacionalidad;

        public Jugador(string nombre, string nacionalidad)
        {
            this.Nombre = nombre;
            this.Nacionalidad = nacionalidad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    }
}
