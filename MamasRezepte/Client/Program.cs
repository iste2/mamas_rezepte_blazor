using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MamasRezepte.Client.State;
using Blazored.Toast;
using MamasRezepte.Client.Helper;

namespace MamasRezepte.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<DataStateEditor>();
            builder.Services.AddScoped<DataStateMain>();
            builder.Services.AddScoped<DataStateDetail>();
            builder.Services.AddScoped<BrowserService>();
            builder.Services.AddBlazoredToast();
            

            await builder.Build().RunAsync();
        }
    }
}
