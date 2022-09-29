using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MudBlazor.Services;

using System.Threading.Tasks;
using System.Text.Json;
using HeladosES.Models;
using HeladosES.Services;

namespace HeladosES
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44369/api/") });

            builder.Services.AddScoped<ISaborHService, SaborHService>();
            builder.Services.AddScoped<IRecipienteService, RecipienteService>();

            builder.Services.AddMudServices();

            await builder.Build().RunAsync();






            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Agregado de codigo para insertar datos de la api
            // traer datos de la api
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            //var url = "https://localhost:44369/api/Recipiente";
            //JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            //using (var httpClient = new HttpClient())
           // {
            //    var response = await httpClient.GetAsync(url);
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var content = await response.Content.ReadAsStringAsync();
            //        var recipiente = JsonSerializer.Deserialize<List<Recipientes>>(content);
           // //    }
            //}

            //var url2 = "https://localhost:44369/api/SaborH";
            //JsonSerializerOptions options2 = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
           //// using (var httpClient2 = new HttpClient())
           // {//
            //    var response = await httpClient2.GetAsync(url2);
             //   if (response.IsSuccessStatusCode)
             //   {
             //       var content2 = await response.Content.ReadAsStringAsync();
              //      var SaborH = JsonSerializer.Deserialize<List<SaborH>>(content2);
             //   }
            //}
        }
    }
}