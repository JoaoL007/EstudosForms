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
        {int municp = 12000;
            int brancos = 0; int nulos = 0; int votos = 0;
            int media = 0;
            Console.WriteLine("insira quantos votaram!");
            votos = int.Parse(Console.ReadLine());
            Console.WriteLine("quantos votos nulos?");
            nulos = int.Parse(Console.ReadLine());
            Console.WriteLine("quantos votos brancos?");
            brancos = int.Parse(Console.ReadLine());
            Console.WriteLine("insira ,+, para encerrar...");
         
            if (votos < municp)
            {
                Console.WriteLine("votos...");
                Console.WriteLine($"Brancos ={brancos}");
                Console.WriteLine($"Nulos ={nulos}");
                Console.WriteLine($"Validos ={votos}");
            }
            
            Console.ReadKey();



        }
    }
}
