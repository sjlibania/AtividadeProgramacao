using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int P1;
            int P2;
            int P3; 
            int P4;
            int P5;
            double ValorSomaProd;
            double ValorPag;
            double troco;

            Console.Write("Digite o valor do primeiro produto: ");
            P1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo produto: ");
            P2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro produto: ");
            P3 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do quarto produto: ");
            P4 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do quinto produto: ");
            P5 = int.Parse(Console.ReadLine());

            ValorSomaProd = P1 + P2 + P3 + P4 + P5;

            Console.Write("O valor da soma dos produtos é:  ");
            Console.WriteLine(ValorSomaProd);

            Console.Write("Digite o valor para pagamento:  ");
            ValorPag = double.Parse(Console.ReadLine());

            troco = ValorPag - ValorSomaProd;

            Console.WriteLine("Este é o seu troco");
            Console.WriteLine(troco);

            





        }
    }
}
