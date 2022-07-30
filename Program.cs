using System;
using System.Collections.Generic;
using System.Text;

namespace semana_2__proyecto_de_consola_calculadora_henry_sanchezpt2
{
    class Program
    {
        static void Main(string[] args)
        { // Declare variables and then initialize to zero.
            Double num1 = 0; Double num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine(" Calculadora de consola en  C#\r");
            Console.WriteLine("------------------------\n");



            // Ask the user to type the first number.

            Console.Write("Digite un número, y presione ENTER: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.
            Console.Write(". digite otro numero y presione ENTER: ");
            num2 = Convert.ToDouble(Console.ReadLine());


            // Ask the user to choose an option.
            Console.WriteLine("Elija un operador de la siguiente lista:");
            Console.WriteLine("\ta - Suma");
            Console.WriteLine("\ts - Resta");
            Console.WriteLine("\tm - Multiplicación");
            Console.WriteLine("\td - Divición");
            Console.Write("Tú opción? "); 


            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"tu resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"tu resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"tu resultado : {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"tu resultado resultado : {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("pulsa cualquier tecla para cerrar la consola ...");
            Console.ReadKey();
        }
    }
}