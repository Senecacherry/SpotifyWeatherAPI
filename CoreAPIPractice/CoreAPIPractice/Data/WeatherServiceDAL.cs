using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoreAPIPractice.Data
{
    public class WeatherServiceDAL : IDAL
    {
        private readonly string BASE_URL;
        public WeatherServiceDAL(IConfiguration Config)
        {
            BASE_URL = Config.GetSection("AppSettings").GetValue<string>("BASE_URL");
        }
        public async Task<List<T>> GetList<T>(Dictionary<string, string> Parameters)
        {
            var coordinates = Parameters["coordinates"];
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BASE_URL);
                var response = await client.GetAsync(coordinates);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
        }

        public async Task<T> Get<T>(Dictionary<string, string> Parameters)
        {
            var coordinates = Parameters["coordinates"];
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Add("User-Agent", "Weather Person");
                var response = await client.GetAsync(coordinates);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}
