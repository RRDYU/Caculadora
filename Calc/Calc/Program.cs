using System;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Primeiro valor: ");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Operação: ");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o Segundo valor: ");
            int v2 = int.Parse(Console.ReadLine());

            int resultado = 0;

           
            switch (operacao)
            {
                case "+":
                    resultado = v1 + v2;
                    break;
                case "-":
                    resultado = v1 - v2;
                    break;
                case "/":
                    resultado = v1 / v2;
                    break;
                case "x":
                    resultado = v1 * v2;
                    break;
            }
            Console.WriteLine("{0} {1}  {2} = {3}", v1, operacao, v2, resultado);
            

          


        }
    }
}
