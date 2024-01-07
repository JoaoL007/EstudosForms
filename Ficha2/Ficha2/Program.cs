using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor total das compras:");
            double valorT = double.Parse(Console.ReadLine());   

            Console.WriteLine("insira o código do cliente: 1 para cliente comum, 2 para funcionário, 3 para cliente vip");
            int codigoC = int.Parse(Console.ReadLine());

            double desconto = 0;

            if (codigoC == 1)
            {
                desconto = 0;
            }
            else if (codigoC == 2)
            {
                desconto = 0.10;
            }
            else if(codigoC == 3) 
            {
                desconto = 0.5;
            }

            double valorD = valorT * desconto;
            double valorF = valorT - valorD;

            Console.WriteLine($"O valor final a ser pago é:R${valorF}");
            Console.ReadKey();
        }
    }
}
