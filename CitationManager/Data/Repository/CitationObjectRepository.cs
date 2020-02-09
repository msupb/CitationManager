using Data.Context;
using Data.Models;
using Reference.Builder.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CitationObjectRepository<T> : IObjectRepository<T> where T : CitationModel
    {
        internal CitationContext context;
        internal DbSet<T> dbSet;

        public CitationObjectRepository()
        {

        }

        public CitationObjectRepository(CitationContext context)
        {
            this.context = context;
            dbSet = this.context.Set<T>();
        }

        public IEnumerable<T> Collection()
        {
            return dbSet;
        }

        public void Delete(int id)
        {
            T t = Get(id);
            dbSet.Remove(t);
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public void Save()
        {
           context.SaveChanges();
        }

        public void Set(T t)
        {
            dbSet.Add(t);
        }

        public void Update(T t)
        {
            dbSet.Attach(t);
            context.Entry(t).State = EntityState.Modified;
        }
    }
}
