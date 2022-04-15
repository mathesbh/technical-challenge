using System;
using System.Collections.Generic;
using Technical.Challenge.Techical.Challenge.Models;
using Xunit;

namespace Technical.Challenge.Testes
{
    public class DivisorsTest
    {
        [Fact]
        public void NumberDivisorsTest()
        {
            //Arrange
            var list = new List<int> { 1, 3, 5, 9, 15, 45 };
            var divisors = new Divisors();
            List<int> returnList;

            //Act
            returnList = divisors.NumberDivisors(45);

            //Assert
            Assert.Equal(list, returnList);

        }

        [Fact]
        public void CheckPrimes()
        {
            //Arrange
            var list = new List<int> { 1, 3, 5, 9, 15, 45 };
            var divisors = new Divisors();
            List<int> returnList = new List<int>();

            //Act
            list.ForEach(x => { if (divisors.CheckPrimes(x)) returnList.Add(x); });

            //Assert
            Assert.Equal(new List<int>{ 1, 3, 5 }, returnList);
        }
    }
}
