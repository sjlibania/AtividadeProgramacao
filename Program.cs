using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a;
            double area;


            Console.Write("Digite o valor da altura do retângulo: ");
            a = double.Parse(Console.ReadLine());

            area = Math.Pow(a, 2);

            Console.Write("O valor da area do retângulo é: ");
            Console.WriteLine(area);


        }
    }
}
