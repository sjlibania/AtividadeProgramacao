using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int c;
            int d;
            int mediaaritmetica;

            Console.Write("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor:  ");
            d = int.Parse(Console.ReadLine());

            mediaaritmetica = (a + b + c + d)/4;
            

            Console.Write("A Média Aritmética dos 4 valores informados é: ");
            Console.WriteLine(mediaaritmetica);


        }
    }
}
