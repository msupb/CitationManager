using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Builder.Core.Citations
{
    public class APACitation : Citation
    {
        public APACitation(List<Author> authors, string title, string year, Publisher publisher, CitationStyle style, CitationType type)
            :base(authors, title, year, publisher, style, type)
        {

        }

        public APACitation(List<Author> authors, string title, string year, CitationStyle style, CitationType type, Journal journal, string doi)
            :base(authors, title, year, style, type, journal, doi)
        {

        }

        protected override string InternalCitationFactory(CitationType type)
        {
            if(type == CitationType.Book)
                return InternalBookCitation();
            if(type == CitationType.Article)
                return InternalArticleCitation();
            //if(type == CitationType.Webpage)

            return null;
        }

        private string InternalBookCitation()
        {
            sb.Clear();
            FormatAuthorNames(authors);
            sb.Append($"({year}).{whiteSpace}");
            sb.Append($"{title}.{whiteSpace}");
            sb.Append($"{publisher.ToString()}.");
            return sb.ToString();
        }

        private string InternalArticleCitation()
        {
            sb.Clear();
            FormatAuthorNames(authors);
            sb.Append($"({year}).{whiteSpace}");
            sb.Append($"{title}.{whiteSpace}");
            sb.Append($"{journal}.{whiteSpace}");
            sb.Append($"doi:{whiteSpace}{doi}");
            return sb.ToString();
        }

        private string FormatAuthorNames(List<Author> names)
        {
            Author lastIndex = names.Last();
            foreach (Author author in names)
            {
                char[] first = author.firstName.ToCharArray();

                if (author.Equals(lastIndex) && authors.Count == 1)
                {
                    sb.Append($"{author.lastName},{whiteSpace}{first[0]}.{whiteSpace}");
                }
                else if (author.Equals(lastIndex) && authors.Count > 1)
                {
                    sb.Append($"&{whiteSpace}{author.lastName},{whiteSpace}{first[0]}.{whiteSpace}");
                }
                else
                {
                    sb.Append($"{author.lastName},{whiteSpace}{first[0]}.,{whiteSpace}");
                }
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return InternalCitationFactory(type);
        }
    }
}
