using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VolunteerForEthiopia.Controllers
{
    public class DonateController : Controller
    {
        // GET: Donate
        public ActionResult Donate()
        {
            return View();
        }
    }
}