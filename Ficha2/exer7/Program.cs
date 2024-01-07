using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o cargo do funcionário:");
            string cargo = Console.ReadLine();

            Console.WriteLine("Digite o salário atual do funcionário:");
            double salarioAtual = double.Parse(Console.ReadLine());

            double aumento = 0;

            
            switch (cargo.ToLower())
            {
                case "gerente":
                    aumento = salarioAtual * 0.10; 
                    break;
                case "analista":
                    aumento = salarioAtual * 0.08; 
                    break;
                case "atendente":
                    aumento = salarioAtual * 0.06; 
                    break;
                default:
                    aumento = salarioAtual * 0.40; 
                    break;
            }

            double novoSalario = salarioAtual + aumento;

            Console.WriteLine($"O novo salário do funcionário é: R${novoSalario}");

            Console.ReadLine();
        }
    }
}
