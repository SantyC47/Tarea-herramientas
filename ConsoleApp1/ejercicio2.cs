/*
using System;
using System.Formats.Asn1;

namespace ConsoleApp1
{
    internal class ejercicio2
    {
        static void Main(string[] args)
        {
            int opc;
            double area = 0, valor_m = 0, cuota_i=0, precio_v=0, desc=0, rec=0;

            Console.WriteLine("Ingrese el area: ");
            area= double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del metro cuadrado: ");
            valor_m= double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Elija la opcion de pago:");
            Console.WriteLine("1: En efectivo.");
            Console.WriteLine("2: Con tarjetas.");
            opc= int.Parse(Console.ReadLine());
            Console.WriteLine();

            precio_v= area*valor_m;
            cuota_i = (precio_v * 20) / 100;

            switch (opc) 
            {
                case 1:
                    desc = (cuota_i * 10) / 100;
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"Valor de la propiedad: {precio_v}");
                    Console.WriteLine($"Cuota inicial: {cuota_i - desc}");
                    Console.WriteLine("*****************************");
                    break;
                case 2:
                    rec = (cuota_i * 8) / 100;
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"Valor de la propiedad: {precio_v}");
                    Console.WriteLine($"Cuota inicial: {cuota_i + rec}");
                    Console.WriteLine("*****************************");
                    break;
            }
        }
    }
}
*/