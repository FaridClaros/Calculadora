using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        public static double Do0peration(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "s":
                    result = num1 + num2;
                    break;
                case "r":
                    result = num1 - num2;
                    break;
                case "d":
                    result = num1 / num2;
                    break;
                case "m":
                    result = num1 * num2;
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;

                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Calculadora de consola en C#\r");
            Console.WriteLine("-----------------------------\n");

            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.Write("Escribe un nùmero y luego presiona enter ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1)) 
                {
                    Console.Write("Este ingreso no es valido. Por favor digita un valor integral");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("Escribe otro nùmero y luego presiona enter ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2)) 
                {
                    Console.Write("Este ingreso no es valido. Por favor digita un valor integral");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("Elige un operador matemàtico de  la lista");
                Console.WriteLine("\ts - Suma");
                Console.WriteLine("\tr - resta");
                Console.WriteLine("\tm - multiplicaciòn");
                Console.WriteLine("\td - division");
                Console.Write("Cual eliges?");

                string op = Console.ReadLine();

                try
                {
                    result = Calculadora.Do0peration(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Esta operacion resultara en un error matematico.\n");
                    }
                    else Console.WriteLine("Tu resultado : {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! Una excepciòn ocurrio tratando de hacer el calculo.\n- Details: " + e.Message);
                }

                Console.WriteLine("----------------------------\n");

                Console.WriteLine("Presiona n y enter para cerrar la app, o presiona cualquier otra tecla y enter para continuar:");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}











    