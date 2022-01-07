using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryService.Core.Domain;

namespace LibraryService.Infrastructure.Services
{
    public interface IResourceService
    {
        Task<List<GenericResource>> GetAllAsync();
        Task<GenericResource> GetAsync(string email);
        Task<GenericResource> GetAsync(int id);
        Task<bool> IsAvailable(int id);
    }
}