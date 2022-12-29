using C1.Blazor.Grid;
using C1.DataCollection;
using CSharpSharedData;

namespace BlazorWasmAppComponentOne.Pages
{
    public partial class FetchData : TimedComponentBase
    {
        FlexGrid grid;
        
        private WeatherForecast[]? forecasts;

        protected override void OnInitialized()
        {
            forecasts = WeatherForecast.Data;
        }

        public void OnGroupSummary()
        {
            grid.DataCollection.GroupAsync(nameof(WeatherForecast.Summary));
        }
    }
}