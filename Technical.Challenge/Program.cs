using System;
using System.Collections.Generic;
using Technical.Challenge.Techical.Challenge.Models;

namespace Technical.Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");

            var divisors = new Divisors();

            var number = Convert.ToInt32(Console.ReadLine());

            var numbers = divisors.NumberDivisors(number);

            List<int> returnList = new List<int>();

            numbers.ForEach(x => { if (divisors.CheckPrimes(x)) returnList.Add(x); });

            Console.WriteLine("Número digitado: {0}", number);

            Console.WriteLine("Números divisores: {0}", string.Join(", ", numbers));

            Console.WriteLine("Divisores Primo: {0}", string.Join(", ", returnList));

            Console.ReadKey();

        }
    }
}
