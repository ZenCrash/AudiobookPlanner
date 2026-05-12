using AudiobookPlanner.Blazor.Application.Dtos;

namespace AudiobookPlanner.Blazor.Infrastructure.Services.Interfaces
{
  public interface IPublishersService
  {
    Task<ICollection<PublisherDto>> GetAllAsync();
    Task<PublisherDto?> GetAsync(int id);
    Task CreateAsync(PublisherDto publisher);
    Task UpdateAsync(PublisherDto publisher);
    Task DeleteAsync(int id);
  }
}
