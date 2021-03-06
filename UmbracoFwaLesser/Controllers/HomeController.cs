﻿using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoFwaLesser.Controllers
{
    public class HomeController : SurfaceController
    {
        private const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/Home/";


        public ActionResult RenderIntro()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Intro.cshtml");
        }

        public ActionResult RenderFeatured()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Featured.cshtml");
        }

        public ActionResult RenderServices()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Services.cshtml");
        }

        public ActionResult RenderBlog()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Blog.cshtml");
        }

        public ActionResult RenderClients()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Clients.cshtml");
        }
    }
}