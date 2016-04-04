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

            Computadora PC1 = new Computadora(true, Enumerados.EMarca.Apple, 125, Enumerados.EProcesador.Intel_Core_i7);

            Console.Write("PC Encendida: "+ PC1.getEstaEncendida());
            Console.Write("\nMarca: " + PC1.getMarca());
            Console.Write("\nPeso: " + PC1.getPeso());
            Console.Write("\nProcesador: " + PC1.getProcesador());

            Console.ReadKey();
        }
    }
}
