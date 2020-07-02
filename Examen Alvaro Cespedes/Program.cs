using System;
using System.Collections.Generic;

namespace Examen_Alvaro_Cespedes
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] paises = { "Chile", "Argentina", "Venezuela", "Brasil", "Peru", "Colombia", "Bolivia", "España" };

            Equipo team = new Equipo();
            Jugador jugador = new Jugador();

            List<Equipo> listaEquipos = new List<Equipo>();

            string entrenador = "Juan";
            string medico = "Carlos";
            
            Console.WriteLine("Bienvenido al simulador.");
            Console.WriteLine("En este simulador se llevaran a cabo");
            Console.WriteLine("los metodos de la clase equipo.");
            while (true)
            {
                Console.WriteLine("------------------MENU----------------------");
                Console.WriteLine("(1) Crear un equipo.");
                Console.WriteLine("(2) Ver info de equipos");
                Console.WriteLine("(0) salir de la app.");
                string numero = Console.ReadLine();
                if(numero == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Nombre del equipo.");
                    string nombreEquipo = Console.ReadLine();
                    Console.WriteLine("Ahora debe seleccionar si el equipo es de liga o nacional");
                    Console.WriteLine("Recuerde que un equipo nacional le permite solo jugares de la misma nacionalidad: ");
                    //Ver el bool del equipo.
                    Console.WriteLine("(1) Nacional");
                    Console.WriteLine("(2) Liga");
                    string opcion = Console.ReadLine();
                    if(opcion == "1")
                    {
                        bool tipoEquipo = true;
                        List<Jugador> listaJugadores = new List<Jugador>();
                        Console.Clear();
                        Console.WriteLine("Debe seleccionar la cantidad de jugadores que desea agregar.");
                        string jugadores1 = Console.ReadLine();
                        int entero = Int32.Parse(jugadores1);
                        int contador = 0;
                        while(contador < entero)
                        {
                            int nacionalidadElegida = 0;
                            Console.WriteLine(" ");
                            Console.WriteLine("Nombre del jugador");
                            string nombreJugador = Console.ReadLine();
                            Console.WriteLine("Selecciona la nacionalidad");
                            for(int a = 0; a < 8; a++)
                            {
                                string var3 = a.ToString();
                                Console.WriteLine("("+var3+ "): " + paises[a]);
                            }
                            string nacionalidadElegida1 = Console.ReadLine();
                            nacionalidadElegida = Int32.Parse(nacionalidadElegida1);
                            jugador = new Jugador(nombreJugador, paises[nacionalidadElegida]);
                            listaJugadores.Add(jugador);
                            contador++;
                        }
                        bool variable = team.CorroborarNacionalidad(jugador, listaJugadores);
                        if (variable != false)
                        {
                            Console.WriteLine("Tu equipo nacional ha sido debidamente agregado.");
                            team = new Equipo(listaJugadores, tipoEquipo, medico, entrenador, nombreEquipo);
                            listaEquipos.Add(team);
                        }
                        else
                        {
                            Console.WriteLine("Deben ser jugadores de la misma nacionalidad");
                            Console.WriteLine("Porfavor verificar");
                            Console.WriteLine("Se volverá al principio.");
                            
                        }
                    }

                    if(opcion== "2")
                    {
                        bool tipoEquipo = false;
                        List<Jugador> listaJugadores = new List<Jugador>();
                        Console.Clear();
                        Console.WriteLine("Debe seleccionar la cantidad de jugadores que desea agregar.");
                        string jugadores1 = Console.ReadLine();
                        int entero = Int32.Parse(jugadores1);
                        int contador = 0;
                        while (contador < entero)
                        {
                            int nacionalidadElegida = 0;
                            Console.WriteLine(" ");
                            Console.WriteLine("Nombre del jugador");
                            string nombreJugador = Console.ReadLine();
                            Console.WriteLine("Selecciona la nacionalidad");
                            for (int a = 0; a < 8; a++)
                            {
                                string var3 = a.ToString();
                                Console.WriteLine("(" + var3 + "): " + paises[a]);

                            }
                            string nacionalidadElegida1 = Console.ReadLine();
                            nacionalidadElegida = Int32.Parse(nacionalidadElegida1);
                            jugador = new Jugador(nombreJugador, paises[nacionalidadElegida]);
                            listaJugadores.Add(jugador);
                            contador++;
                        }
                        team = new Equipo(listaJugadores, tipoEquipo, medico, entrenador, nombreEquipo);
                        listaEquipos.Add(team);
                        Console.WriteLine("Tu equipo de liga ha sido debidamente agregado.");
                    }
                }
                if (numero == "2")
                {
                    Console.Clear();
                    if (listaEquipos.Count > 0)
                    {
                        foreach (Equipo x in listaEquipos)
                        {
                            Console.WriteLine(x);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay equipos inscritos");
                    }
                }
                if (numero == "0")
                {
                    Console.Clear();
                    Console.WriteLine("Has salido de la aplicacion");
                    break;
                }
            }
        }
    }
}
