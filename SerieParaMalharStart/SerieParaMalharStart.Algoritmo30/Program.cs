using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número: ");
            int numUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            int numDois = int.Parse(Console.ReadLine());
            int produto = numUm * numDois;
            Console.WriteLine("O produto dos dois números é " + produto);
            Console.ReadLine();
        }
    }
}
