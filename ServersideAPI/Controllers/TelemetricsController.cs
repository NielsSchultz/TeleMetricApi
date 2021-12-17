using Microsoft.AspNetCore.Mvc;
using ServersideAPI.Data.Entities;
using ServersideAPI.Services;

namespace ServersideAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TelemetricsController : ControllerBase
    {
        
        private readonly ITelemetricService _teleService;

        public TelemetricsController(ITelemetricService teleService)
        {
            _teleService = teleService;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        [HttpGet]
        public List<Telemetrics> Get()
        {
            return _teleService.GetTelemetrics();
        }
    }
}