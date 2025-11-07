using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using HojaVidaApp;
using HojaVidaApp.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


// Registrar el servicio como singleton o scoped (cliente). Usaremos singleton por simplicidad:
builder.Services.AddSingleton<CandidatoService>();


await builder.Build().RunAsync();