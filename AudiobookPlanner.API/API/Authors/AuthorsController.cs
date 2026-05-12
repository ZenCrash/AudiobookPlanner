
using AudiobookPlanner.API.API.Audiobooks.Resources;
using AudiobookPlanner.API.API.Authors.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace AudiobookPlanner.API.API.Authors
{
  [ApiController]
  [Route("api/[controller]")]
  public class AuthorsController(IAuthorsManager manager, IStringLocalizer<Localization> localizer) : ControllerBase
  {
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(AuthorDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<AuthorDto>> Get(int id)
    {
      if (id == null)
        return BadRequest(localizer["Common.IsCannotBeNull"]);
      var result = await manager.GetAsync(id);
      if (result == null)
        return NotFound();
      return Ok(result);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<AuthorDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<AuthorDto>>> GetAll()
    {
      var result = await manager.GetAllAsync();
      return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(typeof(AuthorDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<AuthorDto>> Create(AuthorDto author)
    {
      if (author == null)
        return BadRequest(localizer["Common.AudiobookCannotBeNull"]);
      var result = await manager.CreateAsync(author);
      return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(typeof(AuthorDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<AuthorDto>> Update(int id, AuthorDto author)
    {
      if (id == null)
        return BadRequest(localizer["Common.IsCannotBeNull"]);
      if (author == null)
        return BadRequest(localizer["Common.AudiobookCannotBeNull"]);

      var result = await manager.UpdateAsync(id, author);
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
