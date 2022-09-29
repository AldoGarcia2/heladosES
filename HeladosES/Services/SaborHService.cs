using HeladosES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HeladosES.Services
{
    public class SaborHService : ISaborHService
    {
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public SaborHService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<SaborH>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"SaborH");
            return JsonSerializer.Deserialize<IEnumerable<SaborH>>(resp, options);
        }
        public async Task<SaborH> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"SaborH/{id}");
            return JsonSerializer.Deserialize<SaborH>(resp, options);
        }
    }
}
