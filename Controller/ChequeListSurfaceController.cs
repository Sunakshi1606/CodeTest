using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoChequeApplication.Controller
{
    public class ChequeListSurfaceController : SurfaceController
    {
        public ActionResult RenderShowDetails()
        {
            return PartialView("_ChequeList.cshtml");

        }

    }
}