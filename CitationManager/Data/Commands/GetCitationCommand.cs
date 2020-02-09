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
    public class GetCitationCommand
    {
        private CitationObjectRepository<CitationModel> _objectRepository;
        private int _id;

        public GetCitationCommand(CitationObjectRepository<CitationModel> objectRepository, int id)
        {
            _objectRepository = objectRepository;
            _id = id;
        }
        public void Execute()
        {
            _objectRepository.Get(_id);
        }
    }
}
