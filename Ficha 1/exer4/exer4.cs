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
            int anos = 0; int meses = 0; int dias = 0;

            Console.WriteLine("Quantos anos voce tem?");
            anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos meses voce tem?");
            meses = int.Parse(Console.ReadLine());
            Console.WriteLine("quantos dias voce tem?");
            dias = int.Parse(Console.ReadLine());

            anos = anos * 365;
            meses = meses * 30;
            
            dias = dias + anos + meses;

            Console.WriteLine($"Voce tem {dias} de vida!! ");


            Console.ReadLine();
        }
    }
}
