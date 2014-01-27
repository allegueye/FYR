using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYR.Domain.Concrete
{
    using FYR.Domain.Abstract;
    using FYR.Domain.Entities;
    public class UserRepository : IUserRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<User> CollectionItems
        {
            get {return context.Users; }
        }
    }
}
