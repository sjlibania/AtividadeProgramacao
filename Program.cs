using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double diamentro;
            double area;

            Console.Write("Digite o valor do diâmentro do Círculo:  ");
            diamentro = double.Parse(Console.ReadLine());


            area = Math.Pow( diamentro/2,2) * 3.14;

            Console.Write("O valor da area do círculo é:  ");
            Console.WriteLine(area);
        }
    }
}
