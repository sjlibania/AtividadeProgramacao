using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int b;
            int h;
            int area;

            Console.Write("Digite o valor da Base do Triângulo:  ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do triângulo:  ");
            h = int.Parse(Console.ReadLine());

            area = b * h/2;
            

            Console.Write("Este é o resultado da área do triângulo:  ");
            Console.WriteLine(area);

        }
    }
}
