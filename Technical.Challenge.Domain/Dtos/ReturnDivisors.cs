using System.Collections.Generic;

namespace Technical.Challenge.Domain.Dtos
{
    public class ReturnDivisors
    {
        public int Number { get; set; }
        public IEnumerable<int> DivisorsNumbers { get; set; }
        public IEnumerable<int> PrimeDivisors { get; set; }
        public string Error { get; set; }

    }
}
