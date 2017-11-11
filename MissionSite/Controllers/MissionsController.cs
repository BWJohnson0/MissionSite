using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class MissionsController : Controller
    {
        // GET: Missions
        public ActionResult Index()
        {
            return View();
        }

        // GET: Missions
        //passes parameters to the MissionInfo view when it gets directed towards
        public ActionResult MissionInfo(string Language, String MissionName, string PresidentName, string Address, string Climate, string Religion, string Picture)
        {
            ViewBag.MissionName = MissionName;
            ViewBag.PresidentName = PresidentName;
            ViewBag.Address = Address;
            ViewBag.Climate = Climate;
            ViewBag.Religion = Religion;
            ViewBag.Picture = Picture;
            ViewBag.Language = Language;
            return View();
        }

        [HttpPost]
        public ActionResult FAQAnswers(FormCollection form)
        {
            // String reply = form["New Reply"].ToString();
            // form.Clear();
            return View();
        }
    }
}
