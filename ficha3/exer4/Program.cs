using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira o numero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o numero:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("escolha a operação:");
            char op = char.Parse(Console.ReadLine());

            int res = 0;

            switch (op)
            {
                case '+': 
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':  
                    res = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        res = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Operação inválida. Use +, -, *, ou /.");
                    return;
            }
            Console.WriteLine("Resultado: " + res);

            Console.ReadKey();
        }
    }
}
