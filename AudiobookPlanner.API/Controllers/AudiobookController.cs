using AudiobookPlanner.DataAccess.Models;
using AudiobookPlanner.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AudiobookPlanner.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class AudiobookController(IAudioBookRepository repository) : ControllerBase
  {
    [HttpGet("{id}")]
    public async Task<ActionResult<Audiobook>> Get(int id)
    {
      var audiobook = await repository.GetAsync(id);
      if (audiobook == null)
      {
        return NotFound();
      }
      return Ok(audiobook);
    }

    [HttpGet]
    public async Task<ActionResult<ICollection<Audiobook>>> GetAll()
    {
      var audiobooks = await repository.GetAllAsync();
      return Ok(audiobooks);
    }

    [HttpPost]
    public async Task<ActionResult<Audiobook>> Create(Audiobook audiobook)
    {
      var createdAudiobook = await repository.CreateAsync(audiobook);
      return CreatedAtAction(nameof(Get), new { id = createdAudiobook.Id }, createdAudiobook);
    }

    [HttpPut]
    public async Task<ActionResult<Audiobook>> Update(Audiobook audiobook)
    {
      var updatedAudiobook = await repository.UpdateAsync(audiobook);
      return Ok(updatedAudiobook);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
      await repository.DeleteAsync(id);
      return NoContent();
    }

  }
}
