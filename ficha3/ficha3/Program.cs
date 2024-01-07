using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira o nome do utilizado:");
            string utilizador = Console.ReadLine();
            Console.WriteLine("insira a sua media:");
            double media = double.Parse(Console.ReadLine());
            Console.WriteLine("insira o total de aulas.");
            int aulas = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o seu total de faltas");
            int faltas = int.Parse(Console.ReadLine()); 

            double percentualFaltas = (double)faltas / aulas * 100;

            if (media >= 9.5 && percentualFaltas <= 25)
            {
                Console.WriteLine($"Parabens {utilizador} voce foi APROVADO");       
            }
            else
            {
                Console.WriteLine($"{utilizador}Infelizmente voce foi REPROVADO");
            }
            Console.ReadKey();
        }
    }
}
