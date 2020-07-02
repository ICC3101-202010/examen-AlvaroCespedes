using System;

namespace Examen_Alvaro_Cespedes
{
    class Program
    {

        static void Main(string[] args)
        {
            Equipo team = new Equipo();
            string entrenador = "Juan";
            string medico = "Carlos";

            Console.WriteLine("Bienvenido al simulador.");
            Console.WriteLine("En este simulador se llevaran a cabo");
            Console.WriteLine("los metodos de la clase equipo.");
            Console.WriteLine("Debe crear un equipo.");
            string numero =  Console.ReadLine();
        }
    }
}
