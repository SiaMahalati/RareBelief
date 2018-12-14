using RAREBelief.Domain.Data;
using RAREBelief.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RAREBelief.Web.Controllers
{
    public class BlogController : Controller
    {
        private RareBeliefContext _context;
        public BlogController()
        {
            _context = new RareBeliefContext();
        }
        public ActionResult Index()
        {
            return View(_context.Blogs.ToList());
        }

        public ActionResult Create()
       { 
            return View();
        }

        [HttpPost]
        public ActionResult Create(BlogViewModel model)
        {
            _context.Blogs.Add(new Domain.Model.Blog
            {
                Title = model.Title
            });
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}