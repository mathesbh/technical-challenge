using System.Collections.Generic;
using Technical.Challenge.Helpers;
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
            List<int> returnList;

            //Act
            returnList = Divisors.NumberDivisors(45);

            //Assert
            Assert.Equal(list, returnList);

        }

        [Fact]
        public void CheckPrimes()
        {
            //Arrange
            var list = new List<int> { 1, 3, 5, 9, 15, 45 };
            List<int> returnList = new List<int>();

            //Act
            list.ForEach(x => { if (Divisors.CheckPrimes(x)) returnList.Add(x); });

            //Assert
            Assert.Equal(new List<int>{ 1, 3, 5 }, returnList);
        }
    }
}
