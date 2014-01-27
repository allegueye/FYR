using FYR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYR.Domain.Concrete
{
   public class EFDbContext : DbContext
    {
       public DbSet<User> Users { get; set; }
    }
}
