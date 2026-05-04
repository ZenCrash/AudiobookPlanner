
using AudiobookPlanner.Blazor.Infrastructure.Services;

namespace AudiobookPlanner.Blazor.Application.Views.Audiobooks
{
  public class AudiobooksManager(IAudiobooksService audioBooksService) : IAudiobooksManager
  {

    public async Task<ICollection<Audiobook>> GetAllAsync()
    {
      var resultDtos = await audioBooksService.GetAllAsync();
      return resultDtos.ToModels();
    }

    public Task<Audiobook?> GetAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task CreateAsync(Audiobook audiobook)
    {
      throw new NotImplementedException();
    }

    public Task UpdateAsync(Audiobook audiobook)
    {
      throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
      throw new NotImplementedException();
    }
  }
}
