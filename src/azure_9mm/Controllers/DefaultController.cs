using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;
using azure_9mm.Models;
using azure_9mm.Services;
using azure_9mm.ViewModels.Account;
using Microsoft.Extensions.PlatformAbstractions;

namespace razor_9mm.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IApplicationEnvironment _appEnvironment;

        public DefaultController(IApplicationEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }

        public ActionResult Index()
        {
            ViewBag.pageName = "Main";
            return View();
        }

        public ActionResult Audio()
        {
            ViewBag.pageName = "Audio";
            return View();
        }

        public ActionResult Video()
        {
            ViewBag.pageName = "Video";
            return View();
        }

        public ActionResult Info()
        {   
            ViewBag.pageName = "Info";
            return View();
        }

        public ActionResult News(int? skin = null)
        {
            ViewBag.pageName = "News";
            return View();
        }

        public ActionResult Gallery()
        {
            string basepath = _appEnvironment.ApplicationBasePath;
            string[] files = System.IO.Directory.EnumerateFiles(@"images\9mm_orig\").Select(path => new FileInfo(path).Name).ToArray();
            ViewBag.files = files;
            ViewBag.pageName = "Gallery";
            return View();
        }
    }
}