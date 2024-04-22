using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x;
            double y;
            double ResultadoPotencia;

            Console.Write("Digite o valor de x para calcular sua potência:  ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de y para ser o expoente:  ");
            y = double.Parse(Console.ReadLine());

            ResultadoPotencia = Math.Pow(x, y);

            Console.Write("O Resultado da Potência é:  ");
            Console.WriteLine(ResultadoPotencia);



        }
    }
}
