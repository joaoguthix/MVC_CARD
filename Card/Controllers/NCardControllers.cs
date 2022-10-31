using Card.Data;
using Card.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using Card.ViewModels;

namespace Card.Controllers
{

    [ApiController]
    [Route("v1")] //prefixo de rota
    public class NCardControllers : ControllerBase
    {

        [HttpGet]
        [Route("todos")]
        public async Task<IActionResult> Get(
                [FromServices] AppDbContext context)
        {
            var ncard = await context
                .NCard
                .AsNoTracking()
                .ToListAsync();
            return Ok(ncard);
        }

        [HttpGet]
        //parametro de rota "{}"
        [Route("todos/{id}")]
        public async Task<IActionResult> GetByIdAsync(
           [FromServices] AppDbContext context,
           [FromRoute] int id)
        {
            var ncard = await context
                .NCard
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            return ncard == null
                ? NotFound()
                : Ok(ncard);
        }
        [HttpPost("todos")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateCardViewModels model)
        {
            if (!ModelState.IsValid)

                return BadRequest();

            var ncard = new NCard
            {
                Date = DateTime.Now,
                Done = false,
                TitleName = model.TitleName,
                CardNumber = model.CardNumber,
                Expiration = model.Expiration,
                CVC = model.CVC

            };
            try
            {
                await context.NCard.AddAsync(ncard);
                await context.SaveChangesAsync();
                return Created($"v1/todos/{ncard.Id}", ncard);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}


