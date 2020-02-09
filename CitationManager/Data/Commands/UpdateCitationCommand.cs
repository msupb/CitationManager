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
    public class UpdateCitationCommand
    {
        private CitationObjectRepository<CitationModel> objectRepository;
        private CitationModel citation;
        private readonly object updateLock = new object();

        public UpdateCitationCommand(CitationObjectRepository<CitationModel> objectRepository, CitationModel citation)
        {
            this.objectRepository = objectRepository;
            this.citation = citation;
        }

        public void Execute()
        {
            lock (updateLock)
            {
                objectRepository.Update(citation);
            }        
        }
    }
}
