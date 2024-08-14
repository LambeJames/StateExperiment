using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StateExperiment.Shared.StateContainers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazoredSessionStorage();
builder.Services.AddScoped<IPolicyStateContainer, PolicyStateContainer>();


await builder.Build().RunAsync();
