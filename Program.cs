using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 18";

            string rta = "s";

            Computadora UnaComputadora = new Computadora(true, Enumerados.EMarca.Apple, 125, Enumerados.EProcesador.Intel_Core_i7);

            do
            {
                Console.Clear();
                Console.Write("1.Informar estado\n2.Encender\n3.Apagar\n4.Salir\n\nIngrese su opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Encendida: " + UnaComputadora.getEstaEncendida());
                        Console.Write("\nMarca: " + UnaComputadora.getMarca());
                        Console.Write("\nPeso: " + UnaComputadora.getPeso());
                        Console.Write("\nProcesador: " + UnaComputadora.getProcesador());
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        UnaComputadora.setEstaEncendida(true);
                        break;

                    case 3:
                        Console.Clear();
                        UnaComputadora.setEstaEncendida(false);
                        break;

                    case 4:
                        rta = "n";
                        break;
                }
            } while (rta == "s");
        }
    }
}
