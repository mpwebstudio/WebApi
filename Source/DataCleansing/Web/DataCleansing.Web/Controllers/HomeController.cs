using DataCleansing.Data.Repository;
using DataCleansing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using DataCleansing.Web.ViewModels;

namespace DataCleansing.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }
               
    }
}