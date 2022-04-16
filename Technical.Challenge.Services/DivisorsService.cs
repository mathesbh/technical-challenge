using System;
using System.Collections.Generic;
using Technical.Challenge.Domain.Dtos;
using Technical.Challenge.Domain.Interfaces;
using Technical.Challenge.Helpers;

namespace Technical.Challenge.Services
{
    public class DivisorsService : IDivisorsServices
    {
        public ReturnDivisors DivisorNumberPrimes(int number)
        {
            var returnDivisors = new ReturnDivisors();

            var divisorNumbers = Divisors.NumberDivisors(number);

            if(divisorNumbers != null)
            {
                List<int> divisorsPrime = new List<int>();

                divisorNumbers.ForEach(x => { if (Divisors.CheckPrimes(x)) divisorsPrime.Add(x); });

                returnDivisors.Number = number;
                returnDivisors.DivisorsNumbers = divisorNumbers;
                returnDivisors.PrimeDivisors = divisorsPrime;

                return returnDivisors;
            }

            returnDivisors.Error = "Divisores não encontrado!";

            return returnDivisors;
        }
    }
}
