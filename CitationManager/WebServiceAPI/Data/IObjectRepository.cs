using Reference.Builder.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceAPI
{
    public interface IObjectRepository<T>
    {
        IEnumerable<T> Collection();
        void Save();
        void Delete(int id);
        T Get(int id);
        void Set(T t);
        void Update(T t);
    }
}
