using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {












            int valor, valor2;
            int resul;


            Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.WriteLine("Cálculo da soma entre dois números.");
            Console.WriteLine(" --- Insira dois valores inteiros a serem somados ---");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Valor 1");
            valor = Convert.ToInt16 (Console.ReadLine());
            Console.WriteLine("Valor 2");
            valor2 = Convert.ToInt16 (Console.ReadLine());
            Console.WriteLine();

            resul = valor + valor2;

            Console.WriteLine($"---> {valor} + {valor2} = {resul}");






















        }
    }
}
