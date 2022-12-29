namespace CSharpSharedData;

public class WeatherForecast
{
   public Guid UniqueId { get; set; } = Guid.NewGuid();
   public DateTime LastRendered => DateTime.UtcNow;
   public DateTime Date { get; set; }

   public int TemperatureC { get; set; }

   public string? Summary { get; set; }

   public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

   public static readonly WeatherForecast[] Data = new WeatherForecast[]
   {
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "_Single line"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-06"),
         TemperatureC = 1,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-07"),
         TemperatureC = 14,
         Summary = "Bracing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-08"),
         TemperatureC = -13,
         Summary = "Freezing"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-09"),
         TemperatureC = -16,
         Summary = "Balmy"
      },
      new WeatherForecast
      {
         Date = DateTime.Parse("2018-05-10"),
         TemperatureC = -2,
         Summary = "Chilly"
      }
   };
}
