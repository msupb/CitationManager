using Data.Models;
using Data.Repository;
using Reference.Builder.Core;
using Reference.Builder.Core.Citations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Commands
{
    public class AddCitationCommand : IAddCommand, ICommand
    {
        private IObjectRepository<CitationModel> objectRepository;
        private CitationModel citationModel;
        private ICitationModelMapper mapper;
        private readonly object addLock = new object();

        public AddCitationCommand(IObjectRepository<CitationModel> objectRepository, CitationModel citationModel, ICitationModelMapper mapper)
        {
            this.objectRepository = objectRepository;
            this.mapper = mapper;
            this.citationModel = citationModel;
        }

        public void Add(Citation citation)
        {
            lock (addLock)
            {
                citationModel = mapper.Map(citation);
                objectRepository.Set(citationModel);
                objectRepository.Save();
            }          
        }
    }
}
