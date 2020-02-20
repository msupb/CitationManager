using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceAPI.Data
{
    public class CitationContext : DbContext
    {
        public CitationContext(DbContextOptions<CitationContext> options) : base(options)
        {

        }

        DbSet<CitationModel> CitationModels { get; set; }
    }
}
