using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Laboratorio_5_ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número limite: ");
            int limite = int.Parse(Console.ReadLine());
            Console.WriteLine("============================");
            Console.WriteLine("Escoga una opción");
            Console.WriteLine("1: Números pares");
            Console.WriteLine("2: Números impares");
            Console.WriteLine("3: Factorial");
            Console.Write("-> ");
            int opcion = int.Parse(Console.ReadLine());

            decimal factorial = 1;

            switch (opcion)
            {
                case 1:
                    for (int i = 1; i <= limite; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + ", ");
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < limite; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + 1 + ", ");
                        }
                    }
                    break;
                case 3:
                    for (int i = 1; i <= limite; i++)
                    {
                        factorial = factorial * i;
                    }
                    Console.WriteLine("El factorial es " + factorial);
                    break;
            }
            Console.ReadKey();
        }
    }
}