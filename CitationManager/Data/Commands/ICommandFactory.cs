using Data.Models;
using Data.Repository;
using Reference.Builder.Core.Citations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Commands
{
    public interface ICommandFactory
    {
        IEnumerable<CitationModel> Execute();
        void Execute(Citation citation);
        void Execute(int id);
    }
}
