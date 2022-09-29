using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número: ");
            int numUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            int numDois = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número: ");
            int numTres = int.Parse(Console.ReadLine());
            int media = (numUm + numDois + numTres) / 3;
            Console.WriteLine("A média entre os números é " + media);
            Console.ReadLine();
        }
    }
}
