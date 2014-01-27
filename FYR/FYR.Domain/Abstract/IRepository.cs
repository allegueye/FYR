using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYR.Domain.Abstract
{
   public interface IRepository<T>
    {
        IQueryable<T> CollectionItems {get;}
    }
}
