using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Technical.Challenge.Domain.Dtos;
using Technical.Challenge.Domain.Interfaces;

namespace Technical.Challenge.Api.Controllers
{
    [ApiController]
    [Route("api/divisors")]
    public class DivisorsController : ControllerBase
    {
        private readonly IDivisorsServices _divisorsServices;
        public DivisorsController(IDivisorsServices divisorsServices)
        {
            _divisorsServices = divisorsServices;
        }

        [HttpGet]
        [Route("{number:int}")]
        public ActionResult<ReturnDivisors> Get(int number)
        {
            var divisors = _divisorsServices.DivisorNumberPrimes(number);

            if(divisors.Error == null) return Ok(divisors);

            return BadRequest(divisors.Error);
        }
    }
}
