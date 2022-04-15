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
    }
}
