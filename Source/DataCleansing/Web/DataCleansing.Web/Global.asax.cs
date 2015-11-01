using DataCleansing.Data;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using DataCleansing.Web.App_Start;


namespace DataCleansing.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings(Assembly.GetExecutingAssembly());

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, DataCleansing.Data.Migrations.Configuration>());
            
        }
    }
}
