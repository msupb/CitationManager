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
    public class RemoveCitationCommand : ICommand
    {
        private CitationObjectRepository<CitationModel> objectRepository;
        private int id;

        public RemoveCitationCommand(CitationObjectRepository<CitationModel> objectRepository, int id)
        {
            this.objectRepository = objectRepository;
            this.id = id;
        }

        public void Execute()
        {
            objectRepository.Delete(id);
            objectRepository.Save();
        }
    }
}
