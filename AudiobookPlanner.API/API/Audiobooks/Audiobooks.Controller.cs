using AudiobookPlanner.API.API.Audiobooks.Models;
using AudiobookPlanner.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
namespace AudiobookPlanner.API.API.Audiobooks
{
  [ApiController]
  [Route("api/[controller]")]
  public class AudiobooksController(IAudiobooksManager manager) : ControllerBase
  {
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(AudiobookDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<AudiobookDto>> Get(int id)
    {
      if (id == null)
        return BadRequest("Id cannot be null");
      var result = await manager.GetByIdAsync(id);
      if (result == null)
        return NotFound();
      return Ok(result);
    }

    [HttpGet("byName/{name}")]
    [ProducesResponseType(typeof(AudiobookDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<AudiobookDto>> GetByName(string name)
    {
      if (string.IsNullOrWhiteSpace(name))
        return BadRequest("Id cannot be null");
      var result = await manager.GetByNameAsync(name);
      if (result == null)
        return NotFound();
      return Ok(result);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<AudiobookDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<AudiobookDto>>> GetAll()
    {
      var result = await manager.GetAllAsync();
      return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(typeof(AudiobookDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<AudiobookDto>> Create(AudiobookDto audiobook)
    {
      if (audiobook == null)
        return BadRequest("Audiobook cannot be null");
      var result = await manager.CreateAsync(audiobook);
      return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(typeof(AudiobookDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<AudiobookDto>> Update(int id, AudiobookDto audiobook)
    {
      if (id == null)
        return BadRequest("Id cannot be null");
      if (audiobook == null)
        return BadRequest("Audiobook cannot be null");

      var result = await manager.UpdateAsync(id, audiobook);
      if (result == null)
        return NotFound();

      return Ok(result);
    }

    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
      if (id == null)
        return BadRequest("Id cannot be null");
      var deleted = await manager.DeleteAsync(id);
      if (!deleted)
        return NotFound();

      return NoContent();
    }
  }
}