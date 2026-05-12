using AudiobookPlanner.API.API.Audiobooks.Resources;
using AudiobookPlanner.API.API.Narrators.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace AudiobookPlanner.API.API.Narrators
{
  [ApiController]
  [Route("api/[controller]")]
  public class NarratorsController(INarratorsManager manager, IStringLocalizer<Localization> localizer) : ControllerBase
  {
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(NarratorDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<NarratorDto>> Get(int id)
    {
      if (id == null)
        return BadRequest(localizer["Common.IsCannotBeNull"]);
      var result = await manager.GetAsync(id);
      if (result == null)
        return NotFound();
      return Ok(result);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<NarratorDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<NarratorDto>>> GetAll()
    {
      var result = await manager.GetAllAsync();
      return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(typeof(NarratorDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<NarratorDto>> Create(NarratorDto narrator)
    {
      if (narrator == null)
        return BadRequest(localizer["Common.AudiobookCannotBeNull"]);
      var result = await manager.CreateAsync(narrator);
      return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(typeof(NarratorDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<NarratorDto>> Update(int id, NarratorDto genre)
    {
      if (id == null)
        return BadRequest(localizer["Common.IsCannotBeNull"]);
      if (genre == null)
        return BadRequest(localizer["Common.AudiobookCannotBeNull"]);

      var result = await manager.UpdateAsync(id, genre);
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
        return BadRequest(localizer["Common.IsCannotBeNull"]);
      var deleted = await manager.DeleteAsync(id);
      if (!deleted)
        return NotFound();

      return NoContent();
    }
  }
}
