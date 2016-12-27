using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class QualityController : Controller
    {

        public QualityController()
        {
           
        }
        // GET: Quality
        public ActionResult Index()
        {
            return View();
        }

        // Quality typeahead call
        [HttpGet]
        public JsonResult Find(string id)
        {

            return string.IsNullOrWhiteSpace(id) == false
                ? Json(new QualityRepository().Find(id), JsonRequestBehavior.AllowGet)
                : Json(null, JsonRequestBehavior.AllowGet);

        }

    }
}