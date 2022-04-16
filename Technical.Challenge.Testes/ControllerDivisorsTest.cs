using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Technical.Challenge.Api;
using Technical.Challenge.Domain.Dtos;
using Xunit;

namespace Technical.Challenge.Testes
{
    public class ControllerDivisorsTest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public ControllerDivisorsTest()
        {
            _server = new TestServer(new WebHostBuilder()
           .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task GetControllerDivisorsPrimesTest()
        {
            var number = 10;
            var returnOk = new ReturnDivisors { Number = number, DivisorsNumbers = new List<int> { 1, 2, 5, 10 }, PrimeDivisors = new List<int> { 1, 5 }, Error = null };

            var response = await _client.GetAsync($"/api/divisors/{number}");

            var result = JsonConvert.DeserializeObject<ReturnDivisors>(await response.Content.ReadAsStringAsync());

            Assert.Equal(returnOk.DivisorsNumbers, result.DivisorsNumbers);

        }
    }
}
