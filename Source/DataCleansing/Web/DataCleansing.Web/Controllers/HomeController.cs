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
        private IRepository<BicCodeEurope> bicCodeEurope;

        public HomeController(IRepository<BicCodeEurope> bicCodeEuropeData)
        {
            this.bicCodeEurope = bicCodeEuropeData;
        }

        public ActionResult Index()
        {
            var topCode = this.bicCodeEurope.All().ProjectTo<BicCodeEuropeViewModels>().Take(10);

            return View(topCode);
        }
               
    }
}