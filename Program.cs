using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double mediageometrica;


            Console.Write("Digite o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            mediageometrica = Math.Sqrt(valor1 * valor2);

            Console.Write("A média geométrica dos 2 valores informados é:  ");
            Console.WriteLine(mediageometrica);





        }
    }
}
