using Armitage.Models;
using Armitage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Armitage.Controllers
{
    public class PostMetaDataController : Controller
    {
        private ApplicationDbContext _context;

        public PostMetaDataController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: PostMetaData
        public ActionResult Index()
        {
            return View();
        }

        //GET: ManageTags
        public ActionResult ManageTags()
        {
            ManageTagsViewModel model = new ManageTagsViewModel();
            model.Tags = _context.Tags.ToList();

            return View(model);
        }
        //GET:
        public ActionResult Testing()
        {
            ModelState.Clear();
            return View();
        }

        //GET: 
        public PartialViewResult _TagList()
        {
            ModelState.Clear();
            var model = _context.Tags.ToList();
            return PartialView(model);
        }
        //GET:
        public PartialViewResult _CategoryList()
        {
            ModelState.Clear();
            var model = _context.Categories.ToList();
            return PartialView(model);
        }

        //GET
        public PartialViewResult _AddTag()
        {
            return PartialView();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _AddTag(Tag model)
        {
            Thread.Sleep(2500);
            model.CreatedOn = DateTime.Now;

            model.AddTag();



            return RedirectToAction("_TagList");
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _AddCategory(Category model)
        {
            Thread.Sleep(2500);
            model.CreatedOn = DateTime.Now;

            model.AddCategory();

            return RedirectToAction("_CategoryList");
        }

 
    }
}