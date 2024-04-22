using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotaçaoDolar;
            double ValorDolar;
            double valorReais;
            
            
            Console.Write("Digite o valor da cotação em dolar: ");
            cotaçaoDolar = double.Parse(Console.ReadLine());

            Console.Write("Digite a quatidade de doláres: ");
            ValorDolar = double.Parse(Console.ReadLine());

            valorReais = ValorDolar * cotaçaoDolar;

            Console.Write("O valor da quantidade de dólar referente a contação informada equivale em reais: ");
            Console.WriteLine(valorReais);




        }
    }
}
