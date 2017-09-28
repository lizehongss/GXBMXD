using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Moq;
using GXXD.Domain.Entities;
using GXXD.Domain.Abstract;
using GXXD.Domain.Concrete;
using GXBMXD.Infrastructure.Abstract;
using GXBMXD.Infrastructure.Concrete;

namespace GXXD.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
            ? null : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            /* Mock<IProdustRepositiory> mock = new Mock<IProdustRepositiory>();
             mock.Setup(m => m.Grand).Returns(new List<Grand>
             {
                 new Grand {Name="li",科目一= 25},
                 new Grand {Name="wu",科目一=45 },
                 new Grand {Name="zao", 科目一=56}
             }.AsQueryable());
             ninjectKernel.Bind<IProdustRepositiory>().ToConstant(mock.Object);
             */

            ninjectKernel.Bind<IProdustRepositiory>().To<EFGrandRepository>();
            ninjectKernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }

    }
}