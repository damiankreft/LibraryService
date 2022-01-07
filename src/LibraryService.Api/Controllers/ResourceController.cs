using LibraryService.Infrastructure.Commands;

namespace LibraryService.Api.Controllers
{
    public class ResourceController : ApiControllerBase
    {
        public ResourceController(ICommandDispatcher commandDispatcher) : base(commandDispatcher) { }

        
    }
}