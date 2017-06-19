using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoChequeApplication.Controller
{
    public class HomeController : SurfaceController
    {
        public ActionResult RenderAddChequeDetails()
        {
            return PartialView("~/Views/Partials/Home/_AddChequeDetails.cshtml");
        }

        public ActionResult RenderChequeList()
        {
            return PartialView("~/Views/Partials/Home/_ChequeList.cshtml");
        }

        public ActionResult RenderShowChequeDetails()
        {
            return PartialView("~/Views/Partials/Home/_ShowChequeDetails.cshtml");
        }


    }
}