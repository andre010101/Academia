using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using minhaPrimeiraApi.DataModels;

namespace minhaPrimeiraApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        [HttpGet("nome")]
        public string RetornaNome()
        {
            return "Andre";
        }

        [HttpGet("idade")]
        public int RetornaIdade()
        {
            return 28;
        }

        [HttpPost("nmeRetorno/{nome}")]
        public string pegaNome([FromRoute] string nome)
        {
            return nome;
        }

        [HttpPost("Retorno/{idade}")]
        public int PegaIdade([FromRoute] int idade)
        {
            return idade;
        }





        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult>getAllAsync(
            [FromServices]Contexto contexto)
        {
            var pessoas = await contexto
                .Pessoas
                .AsNoTracking()
                .ToListAsync();
            return pessoas == null ? NotFound() : Ok(pessoas);
        }

        [HttpGet]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> getByIdAsync(
            [FromServices] Contexto contexto,
            [FromRoute] int id
            )
        {
            var pessoa = await contexto
                .Pessoas.AsNoTracking()
                 .FirstOrDefaultAsync(p => p.id == id);
            return pessoa == null ? NotFound() : Ok(pessoa);
        }

        [HttpPost]
        [Route("pessoas")]

        public async Task<IActionResult> PostAsync(
            [FromServices] Contexto contexto,
            [FromBody] Pessoa pessoa
            )
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await contexto.Pessoas.AddAsync(pessoa);
                await contexto.SaveChangesAsync();
                return Created($"api/pessoas/{pessoa.id}", pessoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpPost]
        [Route("pessoas/{id}")]

        public async Task<IActionResult> ActionAsync(
           [FromServices] Contexto contexto,
           [FromBody] Pessoa pessoa,
            [FromRoute] int id
           )
        {
            if (!ModelState.IsValid)
            
            return BadRequest("Model inválida");

            var p = await contexto.Pessoas.FirstAsync(x => x.id == id);

            if (p == null)
                return NotFound("pessoas não encotrada!");


            try
            {
                p.nome = pessoa.nome;
                contexto.Pessoas.Update(p);

                await contexto.SaveChangesAsync();
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete]
        [Route("pessoas/{id}")]

        public async Task<IActionResult> DeleteAsync(
           [FromServices] Contexto contexto,
           
            [FromRoute] int id
           )
        {
            var p = await contexto.Pessoas.FirstAsync(x => x.id == id);
            if (p == null)

                return BadRequest("Pessoa não encotrada");

            try
            {
                
                contexto.Pessoas.Remove(p);

                await contexto.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //    private static readonly string[] Summaries = new[]
        //    {
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //    private readonly ILogger<ApiController> _logger;

        //    public ApiController(ILogger<ApiController> logger)
        //    {
        //        _logger = logger;
        //    }

        //    [HttpGet(Name = "GetWeatherForecast")]
        //    public IEnumerable<WeatherForecast> Get()
        //    {
        //        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //        {
        //            Date = DateTime.Now.AddDays(index),
        //            TemperatureC = Random.Shared.Next(-20, 55),
        //            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //        })
        //        .ToArray();
        //    }
    }
}