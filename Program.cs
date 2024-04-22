using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;


            Console.Write("Digite a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.Write("O valor dado em Celsius transformado em fahrenheit equivale a:  ");
            Console.WriteLine(fahrenheit);

        }
    }
}
