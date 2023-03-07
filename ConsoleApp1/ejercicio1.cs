/*
using System;

namespace taller
{
    internal class ejercicio1
    {
        static void Main(string[] args)
        {
            string codigo;
            double Dias_t=0, salario_d=0, salario_m = 0, impuestos=0, seguro_s = 0, pension=0, subsidio=0 ;

            Console.WriteLine("Ingrese el codigo de usuario");
            codigo= Console.ReadLine();
            Console.WriteLine("Ingrese los dias trabajados");
            Dias_t= double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese salario basico por dia");
            salario_d= double.Parse(Console.ReadLine());

            salario_m = salario_d * Dias_t;

            if( salario_m>= 1400000 ) 
            {
                impuestos= (salario_m*7)/100;
                seguro_s= (salario_m*3)/100;
                pension= (salario_m*2)/100;

                Console.WriteLine($"El codigo del empleado es: {codigo}");
                Console.WriteLine($"El salario neto es: {salario_m}");
                Console.WriteLine("Deducciones:");
                Console.WriteLine($"-7% Impuestos: {impuestos}");
                Console.WriteLine($"-3% Seguro Social: {seguro_s}");
                Console.WriteLine($"-2% Pension: {pension}");
                Console.WriteLine($"Salario total con deducciones: {((salario_m - impuestos) - seguro_s) - pension}");
            }
            else 
            {
                seguro_s= (salario_m*2)/100;
                subsidio= (salario_m*2)/100;
                pension= (salario_m*1.5)/100;

                Console.WriteLine($"El codigo del empleado es: {codigo}");
                Console.WriteLine($"El salario neto es: {salario_m}");
                Console.WriteLine("Deducciones:");
                Console.WriteLine($"-2% Seguro Social: {seguro_s}");
                Console.WriteLine($"-1.5% Pension: {pension}");
                Console.WriteLine($"Subsidio 2%: {subsidio}");
                Console.WriteLine($"Salario total con deducciones y subsidio: {((salario_m - pension) - seguro_s) + subsidio}");
            }
        }
    }
}*/