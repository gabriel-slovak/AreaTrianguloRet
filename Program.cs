using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;
            double h;
            double divisão = 2;

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Calculando a área de um triângulo retângulo");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Console.Write("Digite o valor da base: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.ResetColor();

            Console.Write("Digite o valor da altura: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.ResetColor();

        
            Console.Write("A área do triângulo é: " +b * h /divisão);
            Console.ResetColor();
            Console.WriteLine("\n");

        }
    }
}
