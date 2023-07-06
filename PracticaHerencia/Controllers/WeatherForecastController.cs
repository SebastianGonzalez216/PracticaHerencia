using Microsoft.AspNetCore.Mvc;
using PracticaHerencia.Modelos;

namespace PracticaHerencia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        //metodo post
        [HttpPost]
        public string canino([FromBody] Canino canino)
        {

            //instancia de clase
            PerroDomestico doberman = new PerroDomestico()
            {
                NombreCientifico = "canis lupus familiaris",
                Peso = 18,
                Nombre = "Firulais",
                Raza = "Doberman"     
            };

            //impresion de valores
            return String.Format($"El nombre cientifico del perro es {doberman.NombreCientifico}, su peso es de {doberman.Peso}kg, se llama {doberman.Nombre} y es de raza {doberman.Raza}");
        }
    }
}