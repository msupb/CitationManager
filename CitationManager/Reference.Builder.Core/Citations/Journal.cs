using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference.Builder.Core.Citations
{
    public class Journal
    {
        public string journalName;

        public Journal(string journalName)
        {
            this.journalName = journalName;
        }

        public override string ToString()
        {
            return journalName;
        }
    }
}
