using FYR.Domain.Abstract;
using FYR.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FYR.WebUI.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }


        public ViewResult List()
        {
            UserListViewModel viewModel = new UserListViewModel
            {
                Users = _repository.CollectionItems,
                PagingInfo = new PagingInfo 
                { 
                }
            };


            return View(viewModel.Users);
        }

    }
}
