using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10 , b =20 , temp = 0;
            
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("O valor:");
            Console.WriteLine("A ="+a);
            Console.WriteLine("<B ="+b);
            Console.ReadKey();
        }
    }
}
