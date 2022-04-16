using Microsoft.Extensions.DependencyInjection;
using System;
using Technical.Challenge.Domain.Interfaces;
using Technical.Challenge.Services;

namespace Technical.Challenge
{
    class Program
    {
        private static IDivisorsServices _divisorsServices;
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            var serviceProvider = AddApplicationServicesExtensions.AddApplicatonServices(serviceCollection).BuildServiceProvider();

            _divisorsServices = serviceProvider.GetService<IDivisorsServices>();

            while (true)
            {
                Console.WriteLine("Digite um número: ");

                int number;

                bool success = int.TryParse(Console.ReadLine(), out number);

                if(success)
                {
                    var divisors = _divisorsServices.DivisorNumberPrimes(number);

                    if(divisors.Error == null)
                    {
                        Console.WriteLine("Número digitado: {0}", divisors.Number);

                        Console.WriteLine("Números divisores: {0}", string.Join(", ", divisors.DivisorsNumbers));

                        Console.WriteLine("Divisores Primo: {0}", string.Join(", ", divisors.PrimeDivisors));

                        Console.ReadKey();   
                    }
                    else
                    {
                        Console.WriteLine(divisors.Error);
                    }                             
                }
                else
                {
                    Console.WriteLine("Valor digitado inválido");

                    Console.ReadKey();
                }
                
            }
        }
    }
}
