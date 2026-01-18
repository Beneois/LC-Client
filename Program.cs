using LC.Client;
using LC.Client.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// This line connects the Client to the API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://47.238.231.151/") });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7042/") });
builder.Services.AddScoped<UserSession>();

await builder.Build().RunAsync();