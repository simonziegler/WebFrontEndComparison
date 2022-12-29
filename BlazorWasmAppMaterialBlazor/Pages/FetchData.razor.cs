using CSharpSharedData;
using Material.Blazor;

namespace BlazorWasmAppMaterialBlazor.Pages
{
    public partial class FetchData : TimedComponentBase
    {
        private IEnumerable<KeyValuePair<string, IEnumerable<KeyValuePair<string, WeatherForecast>>>> ForecastsGrouped { get; set; } = default!;
        private List<MBGridColumnConfiguration<WeatherForecast>> ColumnConfigurations { get; set; } = new();
        private bool Grouped { get; set; }
        private string GroupedLabel => Grouped ? "Ungroup" : "Group";


        protected override void OnInitialized()
        {
            base.OnInitialized();
            BuildGrid();
        }

        private void OnGroupClick()
        {
            Grouped = !Grouped;
            BuildGrid();
        }

        private void BuildGrid()
        {
            RenderStopwatch.Restart();

            ForecastsGrouped = new MBGrid_DataHelper<WeatherForecast>().PrepareGridData(
                WeatherForecast.Data,
                typeof(WeatherForecast).GetProperty(nameof(WeatherForecast.UniqueId)),
                typeof(WeatherForecast).GetProperty(nameof(WeatherForecast.TemperatureC)),
                Direction.Ascending,
                null,
                Direction.Ascending,
                Grouped,
                typeof(WeatherForecast).GetProperty(nameof(WeatherForecast.Summary))
            );

            var xxx = ForecastsGrouped.Select(x => new KeyValuePair<string, List<KeyValuePair<string, WeatherForecast>>>(x.Key, x.Value.ToList())).ToList();

            ColumnConfigurations = new()
            {
                new MBGridColumnConfiguration<WeatherForecast>(dataExpression: c => c.LastRendered, title: "Last Rendered", width: 15),
                new MBGridColumnConfiguration<WeatherForecast>(dataExpression: c => c.Date, title: "Date", width: 10),
                new MBGridColumnConfiguration<WeatherForecast>(dataExpression: c => c.TemperatureC, title: "Temp (deg C)", width: 8),
                new MBGridColumnConfiguration<WeatherForecast>(dataExpression: c => c.TemperatureF, title: "Temp (deg F)", width: 8),
                new MBGridColumnConfiguration<WeatherForecast>(dataExpression: c => c.Summary, title: "Summary", width: 8)
            };
        }


    }
}