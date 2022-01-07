using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryService.Core.Domain;
using LibraryService.Core.Repositories;
using LibraryService.Infrastructure.Ef;
using Microsoft.EntityFrameworkCore;

namespace LibraryService.Infrastructure.Repositories
{
    public class ResourceRepository : IResourceRepository
    {
        private readonly LibraryContext _context;

        public ResourceRepository(LibraryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GenericResource>> GetAllAsync()
            => await _context.GenericResources.IgnoreAutoIncludes().ToListAsync();

        public async Task<GenericResource> GetAsync(int id)
            => await _context.GenericResources.SingleOrDefaultAsync(x => x.Id == id);

        public async Task<GenericResource> GetAsync(string title)
            => await _context.GenericResources.SingleOrDefaultAsync(x => x.GenericResourceName.Contains(title));

        public async Task<bool> IsAvailable(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}