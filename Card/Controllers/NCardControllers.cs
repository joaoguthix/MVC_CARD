using Card.Data;
using Card.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;

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
    }
}


