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
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) divisors.Add(i);
            }

            return divisors;
        }
    }
}
