using System.Collections.Generic;

namespace Technical.Challenge.Helpers
{
    public static class Divisors
    {
        public static List<int> NumberDivisors(int number)
        {
            if (number <= 0) return null;

            List<int> divisors = new List<int>();

            for (int i = 1; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);

                    if (i != number / i) divisors.Add(number / i);
                }
            }

            divisors.Sort();

            return divisors;
        }

        public static bool CheckPrimes(int number)
        {
            int divisors = 0;

            if (number == 1) return true;

            for (int i = 1; i <= number; i++)
                if (number % i == 0) divisors++;

            return divisors == 2 ? true : false;
        }
    }
}
