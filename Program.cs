using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0; double num2 = 0;

            Console.WriteLine("Calculadora en consola C#/r");
            Console.WriteLine("-------------------------/n");

            Console.WriteLine("Escriba un numero, luego presione Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba otro numero y presione enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Elija una operacion matematica de la lista");
            Console.WriteLine("\ts-suma");
            Console.WriteLine("\tm-multiplicacion");
            Console.WriteLine("\tr-resta");
            Console.WriteLine("\td-division");
            Console.WriteLine("¿Cuàl es su elecciòn? ");

            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"Su resultado es : {num1} + {num2} = " + (num1 + num2));
                    break;
                case "m":
                    Console.WriteLine($"Su resultado es : {num1} * {num2} =" + (num1 * num2));
                    break;
                case "r":
                    Console.WriteLine($"Su resultado es: {num1} - {num2} =" + (num1 - num2));
                    break;
                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Introduce un numero que no sea 0 para dividir");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Su resultado es : {num1} / {num2} =" + (num1 / num2));
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para cerrar la calculadora consola");
            Console.ReadKey();

        }
    }
}
    