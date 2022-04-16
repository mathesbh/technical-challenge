using System.Collections.Generic;
using Technical.Challenge.Services;
using Xunit;

namespace Technical.Challenge.Testes
{
    public class DivisorsServiceTest
    {
        [Fact]
        public void MethodDivisorNumberPrimesTest()
        {      
            var number = 10;
            var listDivisors = new List<int> { 1, 2, 5, 10 };
            var listDivisorsPrimo = new List<int> { 1, 5 };
            var divisorsService = new DivisorsService();
         
            var divisors = divisorsService.DivisorNumberPrimes(number);

            Assert.Equal(listDivisors, divisors.DivisorsNumbers);
            Assert.Equal(listDivisorsPrimo, divisors.PrimeDivisors);
        }

        [Fact]
        public void MethodErrorDivisorNumberPrimesTest()
        {
            var number = 0;
            string err = "Divisores não encontrado!";
            var divisorsService = new DivisorsService();

            var divisors = divisorsService.DivisorNumberPrimes(number);

            Assert.Equal(err, divisors.Error);
        }
    }
}
