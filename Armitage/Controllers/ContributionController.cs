using Armitage.Models;
using Armitage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Armitage.Controllers
{
    public class ContributionController : Controller
    {
        private ApplicationDbContext _context;

        public ContributionController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Contribution
        public ActionResult Index()
        {
            var model = new NewPostViewModel();
            model.Categories = _context.Categories.ToList();
            return View(model);
        }


    }
}