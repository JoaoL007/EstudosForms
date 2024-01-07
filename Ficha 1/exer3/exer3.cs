using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int B = 0;
            int h = 0;
            int res = 0;

            Console.WriteLine("Insira o valor da Base =");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da Altura =");
            h = int.Parse(Console.ReadLine());

            res = B * h;

            Console.WriteLine($"A area da base do retangulo é ={res}");

            Console.ReadLine(); 
        }
    }
}
