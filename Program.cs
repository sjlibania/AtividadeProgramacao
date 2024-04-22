using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            double area;


            Console.Write("Digite o valor da diagonal do quadrado: ");
            d = double.Parse(Console.ReadLine());

            area = Math.Pow( d, 2)/2;

            Console.Write("O Valor da área do quadrado é: ");
            Console.WriteLine(area);

        }
    }
}
