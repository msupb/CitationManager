using Data.Models;
using Reference.Builder.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class CitationContext : DbContext
    {
        public CitationContext() : base("ReferenceConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CitationContext, Data.Migrations.Configuration>());
        }

        DbSet<CitationModel> CitationsModels { get; set; }
    }
}
