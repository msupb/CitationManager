using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repository;
using Reference.Builder.Core.Citations;

namespace Data.Commands
{
    public class Commandfactory : ICommandFactory
    {
        private IObjectRepository<CitationModel> objectRepository;
        private ICitationModelMapper mapper;

        public Commandfactory(IObjectRepository<CitationModel> objectRepository, ICitationModelMapper mapper)
        {
            this.objectRepository = objectRepository;
            this.mapper = mapper;
        }

        public void Add(Citation citation)
        {
            AddCitationCommand addCommand = new AddCitationCommand(objectRepository, new CitationModel(), mapper);
            addCommand.Add(citation);
        }

        public IEnumerable<CitationModel> GetCitations()
        {
            GetCitationsCommand getCommand = new GetCitationsCommand(objectRepository);
            return getCommand.GetCitations();
        }

        public void Delete(int id)
        {
            RemoveCitationCommand removeCommand = new RemoveCitationCommand(objectRepository, id);
            removeCommand.Execute();
        }
        //TODO: Add support for more operations
    }


}
