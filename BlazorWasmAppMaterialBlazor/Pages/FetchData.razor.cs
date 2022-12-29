using CSharpSharedData;
using Material.Blazor;

namespace BlazorWasmAppMaterialBlazor.Pages
{
    public partial class FetchData : TimedComponentBase
    {
        private IEnumerable<KeyValuePair<string, IEnumerable<KeyValuePair<string, WeatherForecast>>>> forecastsGrouped = default!;
        private List<MBGridColumnConfiguration<WeatherForecast>> columnConfigurations = new();


        protected override void OnInitialized()
        {
            forecastsGrouped = new MBGrid_DataHelper<WeatherForecast>().PrepareGridData(
                WeatherForecast.Data,
                typeof(WeatherForecast).GetProperty(nameof(WeatherForecast.UniqueId)),
                typeof(WeatherForecast).GetProperty(nameof(WeatherForecast.TemperatureC)),
                Direction.Ascending,
                null,
                Direction.Ascending,
                true,
                typeof(WeatherForecast).GetProperty(nameof(WeatherForecast.Summary))
            );

            var xxx = forecastsGrouped.Select(x => new KeyValuePair<string, List<KeyValuePair<string, WeatherForecast>>>(x.Key, x.Value.ToList())).ToList();

            columnConfigurations = new()
            {
                new MBGridColumnConfiguration<WeatherForecast>(dataExpression: c => c.LastRendered, title: "Last Rendered", width: 15),
                new MBGridColumnConfiguration<WeatherForecast>(dataExpression: c => c.Date, title: "Date", width: 10),
                new MBGridColumnConfiguration<WeatherForecast>(dataExpression: c => c.TemperatureC, title: "Temp (deg C)", width: 8),
                new MBGridColumnConfiguration<WeatherForecast>(dataExpression: c => c.TemperatureF, title: "Temp (deg F)", width: 8),
                new MBGridColumnConfiguration<WeatherForecast>(dataExpression: c => c.Summary, title: "Summary", width: 8)
            };
        }

        protected override void OnParametersSet()
        {
            // Call this first to ensure that preparing the grouped data is included within render timing - a fair comparison with other component libraries
            base.OnParametersSet();


        }
    }
}