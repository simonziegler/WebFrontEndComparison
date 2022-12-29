using CSharpSharedData;

namespace BlazorWasmAppMudBlazor.Pages
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