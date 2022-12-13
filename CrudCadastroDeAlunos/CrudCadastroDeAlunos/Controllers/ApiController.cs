using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudCadastroDeAlunos.DataModels;

namespace CrudCadastroDeAlunos.Controller
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        // POST
        // /api/Aluno--  Salvar dados 
        [HttpPost]
        [Route("Aluno")]

        public async Task<IActionResult> PostAsync([FromServices] Contexto contexto, [FromBody] Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await contexto.alunos.AddAsync(aluno);
                await contexto.SaveChangesAsync();
                return Created($"api/Aluno/{aluno.AlunoId}", aluno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // POST
        // /api/Matricula--  Salvar dados 
        [HttpPost]
        [Route("Matricula")]

        public async Task<IActionResult> PostAsync([FromServices] Contexto contexto, [FromBody] Matricula matricula)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await contexto.matriculas.AddAsync(matricula);
                await contexto.SaveChangesAsync();
                return Created($"api/Matricula/{matricula.MatriculaId}", matricula);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }







        // POST
        // /api/Curso --  Salvar dados 
        [HttpPost]
        [Route("Curso")]

        public async Task<IActionResult> PostAsync([FromServices] Contexto contexto, [FromBody] Curso curso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await contexto.Cursos.AddAsync(curso);
                await contexto.SaveChangesAsync();
                return Created($"api/Curso/{curso.CursoId}", curso);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT
        // /api/Curso/{id} --  Atualizar dados 
        [HttpPut]
        [Route("Curso/{id}")]

        public async Task<IActionResult> ActionAsync([FromServices] Contexto contexto, [FromBody] Curso curso, [FromRoute] int id)
        {
            if (!ModelState.IsValid)

                return BadRequest("Model inválida");

            var cursoUpdate = await contexto.Cursos.FirstAsync(x => x.CursoId == id);

            if (cursoUpdate == null)
                return NotFound("curso não encotrado!");


            try
            {
                cursoUpdate.nome = curso.nome;
                contexto.Cursos.Update(cursoUpdate);

                await contexto.SaveChangesAsync();
                return Ok(cursoUpdate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET
        // /api/Curso --  Buscar todos os dados 
        [HttpGet]
        [Route("Curso")]
        public async Task<IActionResult> getAllAsync(
           [FromServices] Contexto contexto)
        {
            var curso = await contexto.Cursos.AsNoTracking().ToListAsync();

            return curso == null ? NotFound() : Ok(curso);
        }

        // GET
        // /api/Curso/{id} --  Buscar um item pelo id
        [HttpGet]
        [Route("Curso/{id}")]
        public async Task<IActionResult> getByIdAsync([FromServices] Contexto contexto, [FromRoute] int id)
        {

            var curso = await contexto.Cursos.AsNoTracking().FirstOrDefaultAsync(a => a.CursoId == id);
            return curso == null ? NotFound() : Ok(curso);
        }


        // DELETE
        // /api/Curso/{id} --  Deletar um item pelo id
        [HttpDelete]
        [Route("Curso/{id}")]

        public async Task<IActionResult> DeleteAsync([FromServices] Contexto contexto, [FromRoute] int id)
        {
            var cursoDelete = await contexto.Cursos.FirstAsync(x => x.CursoId == id);
            if (cursoDelete == null)

                return BadRequest("Cursos não encotrado!");

            try
            {
                contexto.Cursos.Remove(cursoDelete);

                await contexto.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}