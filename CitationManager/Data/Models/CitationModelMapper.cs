using Reference.Builder.Core.Citations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class CitationModelMapper : ICitationModelMapper
    {
        public CitationModel Map(Citation citation)
        {
            CitationModel model = new CitationModel();
            model.CitationString = citation.ToString();
            model.Style = citation.style;
            model.Type = citation.type;

            return model;
        }
    }
}
