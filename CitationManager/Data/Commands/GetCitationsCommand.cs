using Data.Models;
using Data.Repository;
using System.Collections.Generic;

namespace Data.Commands
{
    public class GetCitationsCommand
    {
        private readonly IObjectRepository<CitationModel> objectRepository;
        public GetCitationsCommand(IObjectRepository<CitationModel> objectRepository)
        {
            this.objectRepository = objectRepository;
        }

        public IEnumerable<CitationModel> GetCitations()
        {
            return objectRepository.Collection();
        }
    }
}
