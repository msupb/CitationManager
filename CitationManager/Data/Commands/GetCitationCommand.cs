using Data.Models;
using Data.Repository;

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
