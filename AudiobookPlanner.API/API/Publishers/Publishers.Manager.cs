using AudiobookPlanner.API.API.Authors.Models;
using AudiobookPlanner.API.API.Publishers.Models;
using AudiobookPlanner.API.Data;
using Microsoft.EntityFrameworkCore;

namespace AudiobookPlanner.API.API.Publishers
{
  public class PublishersManager(AudiobookPlannerContext context) : IPublishersManager
  {
    public async Task<PublisherDto?> GetAsync(int id)
    {
      var result = await context.Publishers
        .FirstOrDefaultAsync(a => a.Id == id);
      if (result == null)
        return null;
      return result.ToDto();
    }

    public async Task<ICollection<PublisherDto>> GetAllAsync()
    {
      var result = await context.Publishers
        .ToListAsync();
      return result.ToDtos();
    }

    public async Task<PublisherDto> CreateAsync(PublisherDto publisherDto)
    {
      var model = publisherDto.ToModel();
      context.Publishers.Add(model);

      await context.SaveChangesAsync();
      return model.ToDto();
    }

    public async Task<PublisherDto?> UpdateAsync(int id, PublisherDto publisherDto)
    {
      var resultModel = await context.Publishers.FindAsync(id);
      if (resultModel == null)
        return null;

      publisherDto.ToModel(resultModel);
      await context.SaveChangesAsync();
      return resultModel.ToDto();
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var entity = await context.Publishers.FindAsync(id);
      if (entity == null)
        return false;

      context.Publishers.Remove(entity);
      await context.SaveChangesAsync();
      return true;
    }
  }
}
