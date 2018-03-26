using FormsWithHttpPost.DAL;
using Ninject;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FormsWithHttpPost
{
    public class MvcApplication : NinjectHttpApplication 
    {
        //protected void Application_Start()
        //{
        //    AreaRegistration.RegisterAllAreas();
        //    RouteConfig.RegisterRoutes(RouteTable.Routes);
        //}
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected override IKernel CreateKernel()
        {
            var kernal = new StandardKernel();
            kernal.Bind<IReviewDAL>().To<ReviewSqlDAL>();

            return kernal;
        }
    }
}
