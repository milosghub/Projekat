using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using BusinessLayer;
using DataAccessLayer;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Unity;

namespace WebApplication
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            var container = this.AddUnity();

            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserBusiness, UserBusiness>();


            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}