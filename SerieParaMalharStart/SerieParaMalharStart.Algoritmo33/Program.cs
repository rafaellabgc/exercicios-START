using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numb = int.Parse(Console.ReadLine());
            int sucessor = numb + 1;
            int antecessor = numb - 1;
            Console.WriteLine("O sucessor é " + sucessor + " e o antecessor é " + antecessor);
            Console.ReadLine();
        }
    }
}
