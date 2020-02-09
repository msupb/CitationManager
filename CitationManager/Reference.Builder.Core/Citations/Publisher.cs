using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Builder.Core.Citations
{
    public class Publisher
    {
        string publisher;

        public Publisher(string publisher)
        {
            this.publisher = publisher;
        }

        public override string ToString()
        {
            return publisher;
        }
    }
}
