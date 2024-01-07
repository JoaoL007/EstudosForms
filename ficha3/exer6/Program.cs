using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int numero3 = int.Parse(Console.ReadLine());

            int maiorNumero = numero1; 

            
            if (numero2 > maiorNumero)
            {
                maiorNumero = numero2;
            }

            
            if (numero3 > maiorNumero)
            {
                maiorNumero = numero3;
            }

            Console.WriteLine("O maior número é: " + maiorNumero);
        }
    }
}
