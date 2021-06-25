using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int valor, valor2;
            int resul;

            try
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(" --- Cálculo da soma entre dois números inteiros --- ");
                Console.WriteLine();
                Console.WriteLine("- Insira dois valores inteiros a serem somados.");
                Console.ResetColor();
                Console.WriteLine();

                Console.Write("Valor 1: ");
                valor = Convert.ToInt16(Console.ReadLine());
                Console.Write("Valor 2: ");
                valor2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();

                resul = valor + valor2;

                Console.Beep();
                Console.WriteLine($"---> {valor} + {valor2} = {resul}");
            }
                        
            catch (OverflowException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Atenção!! Inserção de valor não suportado.");
                Console.WriteLine($"Tipo: {ex.GetType()}");
            }

            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Atenção!! Valor não reconhecido.");
                Console.WriteLine($"Tipo: {ex.GetType()}");
            }

            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Erro genérico: {ex.Message}");
                Console.WriteLine($"Tipo: {ex.GetType()}");
            }



        }
    }
}
