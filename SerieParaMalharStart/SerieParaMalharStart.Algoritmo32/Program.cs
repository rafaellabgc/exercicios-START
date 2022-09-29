using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine("O número digitado foi: " + numb + " e seu tipo é " + numb.GetType());
            Console.ReadLine();
        }
    }
}
