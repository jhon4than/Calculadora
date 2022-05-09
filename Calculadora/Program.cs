using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Calculadora");
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Operação");
            Console.WriteLine("Digite + (soma) - (Subtração) x (Multiplicação) / (Divisão): ");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo número");
            int num2 = int.Parse(Console.ReadLine());

            int resultado =0;

            if (operacao == "+")
            {
                resultado = num1 + num2;
            }
            else if (operacao == "-")
            {
                resultado = num1 - num2;
            }
            else if(operacao == "x")
            {
                resultado = num1 * num2;
            }
            else if(operacao == "/")
            {
                resultado = num1 / num2;
            }
            else
            {
                Console.WriteLine("Ocorreu um erro na operação");
            }

            /*
            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "x":
                    resultado = num1 * num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;
                default :
                    Console.WriteLine("Erro na operação!");
                    break;
            }
            */

            Console.WriteLine("{0} {1} {2} = {3}", num1, operacao, num2, resultado);

            Console.WriteLine("Digite uma tecla para voltar ao início");

            Console.ReadKey();

            goto inicio; //Voltar para o início
        }
    }
}
