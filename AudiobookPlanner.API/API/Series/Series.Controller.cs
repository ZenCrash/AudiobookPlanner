using AudiobookPlanner.API.API.Audiobooks.Resources;
using AudiobookPlanner.API.API.Series.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace AudiobookPlanner.API.API.Series
{
  [ApiController]
  [Route("api/[controller]")]
  public class SeriesController(ISeriesManager manager, IStringLocalizer<Localization> localizer) : ControllerBase
  {
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(SeriesDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<SeriesDto>> Get(int id)
    {
      if (id == null)
        return BadRequest(localizer["Common.IsCannotBeNull"]);
      var result = await manager.GetAsync(id);
      if (result == null)
        return NotFound();
      return Ok(result);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<SeriesDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<SeriesDto>>> GetAll()
    {
      var result = await manager.GetAllAsync();
      return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(typeof(SeriesDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<SeriesDto>> Create(SeriesDto series)
    {
      if (series == null)
        return BadRequest(localizer["Common.AudiobookCannotBeNull"]);
      var result = await manager.CreateAsync(series);
      return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(typeof(SeriesDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<SeriesDto>> Update(int id, SeriesDto series)
    {
      if (id == null)
        return BadRequest(localizer["Common.IsCannotBeNull"]);
      if (series == null)
        return BadRequest(localizer["Common.AudiobookCannotBeNull"]);

      var result = await manager.UpdateAsync(id, series);
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
