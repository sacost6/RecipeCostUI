using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RecipeCostUI; // Make sure this matches your namespace
using RecipeCost.Shared; // This allows the UI to use your shared models

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// This is your "Phone" to the API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5210") });

// This registers your service so pages can use it
builder.Services.AddScoped<IngredientService>();

await builder.Build().RunAsync();
