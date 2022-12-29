using CSharpSharedData;
using System.Net.Http.Json;

namespace BlazorWasmAppSyncFusion.Pages
{
   public partial class FetchData : TimedComponentBase
    {
        private WeatherForecast[]? forecasts;

        protected override void OnInitialized()
        {
         forecasts = WeatherForecast.Data;
        }
    }
}