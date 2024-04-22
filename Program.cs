using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double quilometros;
            double milhasNauticas;

            Console.Write("Digite o número de milhas Náuticas: ");
            milhasNauticas = double.Parse(Console.ReadLine());


            quilometros = (milhasNauticas * 1.852)/ 0.001;

            Console.Write("O resultado desse valor de milhas marítimas em km é: ");
            Console.WriteLine(quilometros);

        }
    }
}
