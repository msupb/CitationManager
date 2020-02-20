using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Builder.Core.Citations
{
    public abstract class Citation
    {
        protected string title;
        protected Publisher publisher;
        protected Journal journal;
        protected string doi;
        protected string year;
        protected List<Author> authors = new List<Author>();
        protected StringBuilder sb = new StringBuilder();
        public CitationStyle Style;
        public CitationType Type;
        public string CitationString;
        protected const string whiteSpace = " ";

        public Citation(List<Author> authors, string title, string year, Publisher publisher, CitationStyle style, CitationType type)
        {
            this.authors = authors;
            this.year = year;
            this.publisher = publisher;
            this.Style = style;
            this.Type = type;
            this.title = title;
        }

        public Citation(List<Author> authors, string title, string year, CitationStyle style, CitationType type, Journal journal, string doi)
        {
            this.authors = authors;
            this.year = year;
            this.Style = style;
            this.Type = type;
            this.title = title;
            this.journal = journal;
            this.doi = doi;
        }

        protected abstract string InternalCitationFactory(CitationType type);

        public override string ToString()
        {
            return InternalCitationFactory(Type);
        }
    }
}
