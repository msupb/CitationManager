using Reference.Builder.Core;
using Reference.Builder.Core.Citations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Builder.Core
{
    public class CitationDetailsObject
    {
        public List<Author> authors { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public Publisher publisher { get; set; }
        public Journal journal { get; set; }
        public CitationType type { get; set; }
        public CitationStyle style { get; set; }
    }
}
