using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val, antecessor;

            Console.WriteLine("insira o valor:");
            val = int.Parse(Console.ReadLine());

            antecessor = val - 1;

            Console.WriteLine($"O antecessor de {val} e {antecessor}! ");
            Console.ReadKey();
        }
    }
}
