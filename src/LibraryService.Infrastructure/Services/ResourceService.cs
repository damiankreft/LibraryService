using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryService.Core.Domain;
using LibraryService.Core.Repositories;
using System.Linq;
using System;

namespace LibraryService.Infrastructure.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IResourceRepository _repository;
        public ResourceService(IResourceRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GenericResource>> GetAllAsync()
        {
            var resources =  await _repository.GetAllAsync();

            return resources.ToList();
        }

        public async Task<GenericResource> GetAsync(string title)
            => await _repository.GetAsync(title);

        public async Task<GenericResource> GetAsync(int id)
            => await _repository.GetAsync(id);

        public async Task<bool> IsAvailable(int id)
        {
            throw new NotImplementedException();
        }
    }
}