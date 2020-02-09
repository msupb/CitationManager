using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Builder.Core.Citations
{
    public interface ICitationFactory
    {
        Citation CreateCitation(CitationDetailsObject details);
    }
}
