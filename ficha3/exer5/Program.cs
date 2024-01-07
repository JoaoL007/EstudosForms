using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Digite o salário atual em euros:");
                double salario = double.Parse(Console.ReadLine());

                double novoSalario = 0;

                if (salario < 700)
                {
                    novoSalario = salario * 1.10; 
                }
                else if (salario > 1500)
                {
                    novoSalario = salario * 1.05; 
                }
                else
                {
                    novoSalario = salario * 1.075; 
                }

                Console.WriteLine("Novo salário: " + novoSalario.ToString("C")); 
            }
        }
    }

}
    

