using CSharpSharedData;

namespace BlazorWasmAppRadzen.Pages
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