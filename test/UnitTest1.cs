using System.Runtime.InteropServices;
using System.Reflection;
using ProEvent.API;
using Xunit;

namespace ProEvent.UnitTest;


public class UnitTest1
{
    [Fact(DisplayName = nameof(Test1))]
    [Trait("Domain","Category - Aggregates")]
    public void Test1()
    {
           var validDate = new {
            Summary ="category name",
            TemperatureC= 22
        };

        var weather = new WeatherForecast("Teste", validDate.TemperatureC);

         Assert.NotNull(weather);
         Assert.Equal(validDate.Summary, weather.Summary);

    }
}