using System;

namespace Examen_Alvaro_Cespedes
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] paises = { "Chile", "Argentina", "Venezuela", "Brasil", "Peru", "Colombia", "Bolivia" };


            Equipo team = new Equipo();
            string entrenador = "Juan";
            string medico = "Carlos";
            
            Console.WriteLine("Bienvenido al simulador.");
            Console.WriteLine("En este simulador se llevaran a cabo");
            Console.WriteLine("los metodos de la clase equipo.");
            while (true)
            {
                Console.WriteLine("------------------MENU----------------------");
                Console.WriteLine("(1) Crear un equipo.");
                Console.WriteLine("(2) Ver info de equipo");
                Console.WriteLine("(3) salir de la app.");
                string numero = Console.ReadLine();
                if(numero == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Nombre del equipo.");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ahora debe seleccionar si el equipo es de liga o nacional");
                    Console.WriteLine("Recuerde que un equipo nacional le permite solo jugares de la misma nacionalidad: ");
                    Console.WriteLine("(1) Nacional");
                    Console.WriteLine("(2) Liga");
                    string opcion = Console.ReadLine();
                    if(opcion == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Debe seleccionar la cantidad de jugadores que desea agregar.");
                        string jugadores1 = Console.ReadLine();
                        int entero = Int32.Parse(jugadores1);
                        int contador = 0;
                        while(contador < entero)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Nombre del jugador");
                            string nombreJugador = Console.ReadLine();
                            Console.WriteLine("Selecciona la nacionalidad");
                            for(int a = 0; a < 7; a++)
                            {
                                string var3 = a.ToString();
                                Console.WriteLine("("+var3+ "): " + paises[a]);
                            }
                        }
                    }
                }
                if (numero == "2")
                {
                    Console.Clear();
                }
                if (numero == "3")
                {
                    break;
                }
            }
        }
    }
}
