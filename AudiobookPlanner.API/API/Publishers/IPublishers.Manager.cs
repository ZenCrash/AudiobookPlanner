using AudiobookPlanner.API.API.Narrators.Models;
using AudiobookPlanner.API.API.Publishers.Models;

namespace AudiobookPlanner.API.API.Publishers
{
  public interface IPublishersManager
  {
    Task<PublisherDto?> GetAsync(int id);
    Task<ICollection<PublisherDto>> GetAllAsync();
    Task<PublisherDto> CreateAsync(PublisherDto publisherDto);
    Task<PublisherDto?> UpdateAsync(int id, PublisherDto publisherDto);
    Task<bool> DeleteAsync(int id);
  }
}
