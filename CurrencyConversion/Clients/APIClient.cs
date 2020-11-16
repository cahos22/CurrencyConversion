using CurrencyConversion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrencyConversion.Clients
{
    public class APIClient
    {
        private static readonly HttpClient client = new HttpClient();

        private const string BASE_URL = "http://data.fixer.io/api/";

        private static readonly clientKey= 

        private static async Task<List<Currency>> GetSymbols()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");

            var msg = await stringTask;
            Console.Write(msg);

        }
    }
}
