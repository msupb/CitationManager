using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Builder.Core.Citations
{
    public class CitationFactory : ICitationFactory
    {
        public CitationFactory()
        {
            
        }

        public Citation CreateCitation(CitationDetailsObject details)
        {
            if(details.style == CitationStyle.APA)
            {
                if(details.type == CitationType.Book)
                    return new APACitation(details.authors, details.title, details.year, details.publisher, details.style, details.type);
            }
                
            return null;
        }
    }
}
