using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FYR.WebUI.Infrastructure
{
    using FYR.Domain.Abstract;
    using FYR.Domain.Concrete;
    using FYR.Domain.Entities;
    using Moq;
    public class UnityControllerFactory : DefaultControllerFactory
    {
        private IUnityContainer _container;
        public UnityControllerFactory()
        {
            _container = new UnityContainer();

            //Register();
            RegisterMock();
        }
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            //Contract.Requires<ArgumentNullException>(null != controllerType);
            if (controllerType == null)
                throw new ArgumentNullException("controllerType");

            var controller = _container.Resolve(controllerType) as IController;

            return controller;
        }


        private void Register()
        {
            _container.RegisterType<IUserRepository, UserRepository>();
        }


        private void RegisterMock()
        {
            Mock<IUserRepository> mock = new Mock<IUserRepository>();

            
            IList<User> users = new List<User>();
            for (int i = 0; i < 10; i++)
            {
              var user =  new User { LastName = "LastName " + i, FirstName = "FirstName " + i };

              users.Add(user);
            }

            mock.Setup(m => m.CollectionItems).Returns(users.AsQueryable());

            _container.RegisterInstance(typeof(IUserRepository), mock.Object);
            
        }
    }
}