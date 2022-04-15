using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical.Challenge.Techical.Challenge.Models
{
    public class Divisors
    {
        public List<int> NumberDivisors(int number)
        {
            List<int> divisors = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) divisors.Add(i);
            }

            return divisors;
        }

        public bool CheckPrimes(int number)
        {
            int divisors = 0;

            if (number == 1) return true;

            for (int i = 1; i <= number; i++)
                if (number % i == 0) divisors++;

            return divisors == 2 ? true : false;
        }
    }
}
