using Reference.Builder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class CitationModel
    {
        public int Id { get; set; }
        public string CitationString { get; set; }
        public CitationType Type { get; set; }
        public CitationStyle Style { get; set; }

    }
}
