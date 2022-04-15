using System;
using System.Collections.Generic;
using Technical.Challenge.Helpers;

namespace Technical.Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");

            var number = Convert.ToInt32(Console.ReadLine());

            var numbers = Divisors.NumberDivisors(number);

            List<int> returnList = new List<int>();

            numbers.ForEach(x => { if (Divisors.CheckPrimes(x)) returnList.Add(x); });

            Console.WriteLine("Número digitado: {0}", number);

            Console.WriteLine("Números divisores: {0}", string.Join(", ", numbers));

            Console.WriteLine("Divisores Primo: {0}", string.Join(", ", returnList));

            Console.ReadKey();

        }
    }
}
