using BlazorBootstrap.Notika;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

WebAssemblyHostBuilder Builder = WebAssemblyHostBuilder.CreateDefault(args);
Builder.RootComponents.Add<App>("#app");
Builder.RootComponents.Add<HeadOutlet>("head::after");
Builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(Builder.HostEnvironment.BaseAddress) });
await Builder.Build().RunAsync();