using Data.Models;
using Data.Repository;
using Reference.Builder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
