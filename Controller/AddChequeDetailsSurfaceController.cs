using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoChequeApplication.Model;

namespace UmbracoChequeApplication.Controller
{
    public class AddChequeDetailsSurfaceController:SurfaceController
    {

        public ActionResult Index()
        {
            AddChequeDetails chqdts = new AddChequeDetails();
            return View(chqdts);

        }
        public ActionResult RenderAdd(AddChequeDetails chqdts)
        {
            TempData["CheqDtls"] = chqdts;
            return PartialView("_AddChequeDetails.cshtml");

        }

        public ActionResult SubmitForm()
        {
            if(ModelState.IsValid)
            {
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();

        }

        public ActionResult CheqDetails()
        {

            AddChequeDetails chqdts = TempData["CheqDtls"] as AddChequeDetails;
            return View(chqdts);
        }

    }
}