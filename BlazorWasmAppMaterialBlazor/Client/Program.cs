using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Material.Blazor;

namespace BlazorWasmAppMaterialBlazor
{
   public class Program
   {
      public static async Task Main(string[] args)
      {
         var builder = WebAssemblyHostBuilder.CreateDefault(args);
         builder.RootComponents.Add<App>("#app");
         builder.RootComponents.Add<HeadOutlet>("head::after");
         
         builder.Services.AddMBServices();
         builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

         await builder.Build().RunAsync();
      }
   }
}