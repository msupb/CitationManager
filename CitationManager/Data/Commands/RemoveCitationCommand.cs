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
    public class RemoveCitationCommand
    {
        private IObjectRepository<CitationModel> objectRepository;
        private int id;
        private readonly object removeLock = new object();

        public RemoveCitationCommand(IObjectRepository<CitationModel> objectRepository, int id)
        {
            this.objectRepository = objectRepository;
            this.id = id;
        }

        public void Execute()
        {
            lock (removeLock)
            {
                objectRepository.Delete(id);
                objectRepository.Save();
            }     
        }
    }
}
