/*
using System;

namespace ConsoleApp1
{
    internal class ejercicio5
    {
        static void Main(string[] args)
        {

            string[] name = new string[5];
            string[] cod = new string[5];
            int[] horas = new int[5];
            int[] salario = new int[5];
            
            int extra, extra1=0, extra2=0, salario_t=0;

            for(int i=0; i<name.Length ; i++) 
            {
                Console.WriteLine("ingrese el nombre del trabajador: ");
                //name[i] = Console.ReadLine();
                Console.WriteLine("ingrese el codigo del trabajador: ");
                //cod[i] = Console.ReadLine();
                Console.WriteLine("ingrese las horas trabajadas: ");
                horas[i] = int.Parse(Console.ReadLine());
            }

            for (int j=0; j<name.Length ; j++)
            {
                if (horas[j] <= 40) 
                {
                    salario[j] = 500 * horas[j];
                }
                else
                {
                    extra = horas[j] - 40;
                    extra1 = extra1 + extra;
                    extra = (extra * 700) + (40 * 500);
                    salario[j] = extra;
                }

                salario_t = salario_t + salario[j];
            }

            extra2 = extra1 * 700;

            Console.WriteLine($"La empresa paga un total de {salario_t} en salarios");
            Console.WriteLine($"El valor promedio de las horas extras pagadas es: {extra2 / name.Length}");

        }
    }
}*/

