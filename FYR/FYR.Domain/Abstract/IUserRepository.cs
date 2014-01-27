﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYR.Domain.Abstract
{
    using FYR.Domain.Entities;

    public interface IUserRepository:IRepository<User>
    {
    }
}
