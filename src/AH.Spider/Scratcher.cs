using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AH.Spider
{
    public class Scratcher : IScratcher
    {
        private readonly HttpClient _client;

        public Scratcher(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> ScratchBrand()
        {
            var response = await _client.GetStringAsync("https://car.autohome.com.cn");
            return response;
        }

        public Task<string> ScratchModel()
        {
            throw new NotImplementedException();
        }

        public Task<string> ScratchSeries()
        {
            throw new NotImplementedException();
        }

    }
}
