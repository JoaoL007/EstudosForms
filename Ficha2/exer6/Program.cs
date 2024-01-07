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
            double pesoideal = 0;
            char M = Masculino, F;
            Console.WriteLine("Insira a sua altura:");
            int alt = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o seu sexo M ou F:");
            string sex = Console.ReadLine();

            if (sex == "M")
            {
                pesoideal = (72.7 * alt) - 58;
            }
            else if (sex == "F")
            {
                pesoideal = (62.1 * alt) - 44.7;
            }
            Console.WriteLine($"O seu peso ideal é:{pesoideal}");


        }
    }
}
