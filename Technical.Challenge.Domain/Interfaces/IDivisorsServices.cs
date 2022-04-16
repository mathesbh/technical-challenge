
using Technical.Challenge.Domain.Dtos;

namespace Technical.Challenge.Domain.Interfaces
{
    public interface IDivisorsServices
    {
        ReturnDivisors DivisorNumberPrimes(int number);
    }
}
