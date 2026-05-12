using AudiobookPlanner.API.API.Languages.Models;
using AudiobookPlanner.API.API.Narrators.Models;

namespace AudiobookPlanner.API.API.Narrators
{
  public interface INarratorsManager
  {
    Task<NarratorDto?> GetAsync(int id);
    Task<ICollection<NarratorDto>> GetAllAsync();
    Task<NarratorDto> CreateAsync(NarratorDto narratorDto);
    Task<NarratorDto?> UpdateAsync(int id, NarratorDto narratorDto);
    Task<bool> DeleteAsync(int id);
  }
}
