using AudiobookPlanner.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace AudiobookPlanner.API.API.Audiobooks
{
  [ApiController]
  [Route("api/[controller]")]
  public class AudiobooksController(IAudiobooksManager manager) : ControllerBase
  {
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(Audiobook), StatusCodes.Status200OK)]
    public async Task<ActionResult<Audiobook>> Get(int id)
    {
      var result = await manager.GetByIdAsync(id);
      if (result == null)
        return NotFound();

      return Ok(result);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Audiobook>), StatusCodes.Status200OK)]
    public async Task<ActionResult<List<Audiobook>>> GetAll()
    {
      return Ok(await manager.GetAllAsync());
    }

    [HttpPost]
    [ProducesResponseType(typeof(Audiobook), StatusCodes.Status200OK)]
    public async Task<ActionResult<Audiobook>> Create(Audiobook audiobook)
    {
      var result = await manager.CreateAsync(audiobook);
      return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(typeof(Audiobook), StatusCodes.Status200OK)]
    public async Task<ActionResult<Audiobook>> Update(int id, Audiobook audiobook)
    {
      return Ok(await manager.UpdateAsync(id, audiobook));
    }

    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult> Delete(int id)
    {
      if(id == null)
        return BadRequest("Id is null");

      if (await manager.DeleteAsync(id))
        return NotFound();
      return Ok();
    }
  }
}
