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
    public class GetCitationsCommand : IGetCitationsCommand, ICommand
    {
        private readonly CitationObjectRepository<CitationModel> objectRepository;
        public GetCitationsCommand(CitationObjectRepository<CitationModel> objectRepository)
        {
            this.objectRepository = objectRepository;
        }

        public IEnumerable<CitationModel> GetCitations()
        {
            return objectRepository.Collection();
        }
    }
}
