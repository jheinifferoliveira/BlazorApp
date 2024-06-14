using BlazorApp;
using BlazorApp.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped
    (sp => new HttpClient());
    



builder.Services.AddBlazoredLocalStorage();
builder.Services.AddTransient<AuthService>();

await builder.Build().RunAsync();
