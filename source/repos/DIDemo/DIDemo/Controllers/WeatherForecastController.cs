using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


        private IServiceProvider _ServiceProvider;
        public WeatherForecastController(IServiceProvider ServiceProvider)
        {
           _ServiceProvider = ServiceProvider;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast>? Get()
        {
            Console.WriteLine(".............Request start................\n");

            var scoped1 = _ServiceProvider.GetService(typeof(IScoped));
            var scoped2 = _ServiceProvider.GetService(typeof(IScoped));

            var singleton1 = _ServiceProvider.GetService(typeof(ISingleton));
            var singleton2 = _ServiceProvider.GetService(typeof(ISingleton));

            var transient1 =_ServiceProvider.GetService(typeof(ITransient));
            var transient2 = _ServiceProvider.GetService(typeof(ITransient));
            var transient3 = _ServiceProvider.GetService(typeof(ITransient));

            Console.WriteLine("\n...............Request End..................\n");
            return null;
        }
    }
}