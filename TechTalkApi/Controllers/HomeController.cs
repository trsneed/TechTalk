using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTalkDomain.Repository;

namespace TechTalkApi.Controllers
{
    public class HomeController : Controller
    {
                private readonly TechTalkRepository repository;
                public HomeController(TechTalkRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }
            this.repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
