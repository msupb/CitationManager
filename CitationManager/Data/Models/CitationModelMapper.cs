using Reference.Builder.Core.Citations;
using AutoMapper;

namespace Data.Models
{
    public class CitationModelMapper : ICitationModelMapper
    {
        public CitationModel Map(Citation source)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Citation, CitationModel>();
            });

            IMapper mapper = config.CreateMapper();
            CitationModel destination = mapper.Map <Citation, CitationModel>(source);

            return destination;
        }
    }
}
