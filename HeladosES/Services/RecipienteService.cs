using HeladosES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HeladosES.Services
{
    public class RecipienteService : IRecipienteService
    {
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public RecipienteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Recipientes>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Recipiente");
            return JsonSerializer.Deserialize<IEnumerable<Recipientes>>(resp, options);
        }
        public async Task<Recipientes> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Recipiente/{id}");
            return JsonSerializer.Deserialize<Recipientes>(resp, options);
        }
    }
}
