using FYR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FYR.WebUI.Models
{
    public class UserListViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}