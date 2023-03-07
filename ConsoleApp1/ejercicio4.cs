/*
using System;

namespace taller
{
    internal class ejercicio4
    {
        static void Main(string[] args)
        {
            int cant = 0;
            double suma_1 = 0, suma_t = 0, suma_p = 0;

            Console.WriteLine("ingrese la cantidad de numeros: ");
            cant = int.Parse(Console.ReadLine());

            double[] num = new double[cant];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero {i + 1}");
                num[i] = double.Parse(Console.ReadLine());
            }

            for (int j = 0; j < num.Length; j++)
            {
                if (num[j] % 5 == 0)
                {
                    Console.WriteLine($"El numero {num[j]} es multiplo de 5");
                }
                else
                {
                    suma_1 = suma_1 + num[j];
                }

                if (num[j] >= 0)
                {
                    suma_p = suma_p + 1;
                }
                suma_t = suma_t + num[j];
            }

            Console.WriteLine($"La suma de los numeros que no son multiplos de 5 es: {suma_1}");
            Console.WriteLine($"El promedio de todos los numeros es: {suma_t / cant}");
            Console.WriteLine($"El porcentaje de los positivos es: {(suma_p * 100) / cant}%");
        }
    }
}*/