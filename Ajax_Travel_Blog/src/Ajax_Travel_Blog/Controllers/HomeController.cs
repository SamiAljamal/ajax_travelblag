using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ajax_Travel_Blog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Ajax_Travel_Blog.Controllers
{

    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public IActionResult suggestionList()
        {
            var List = db.Suggestions.ToList();
            return Json(List);
        }

        [HttpPost]
        public IActionResult NewSuggestion(string newPlace, string newDescription)
        {
            Suggestion newSuggestion = new Suggestion(newPlace, newDescription);
            db.Suggestions.Add(newSuggestion);
            db.SaveChanges();
            var List = db.Suggestions.ToList();
            return Json(List);
        }
        //private readonly ApplicationDbContext _db;
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;
        //private IHostingEnvironment _environment;
        //// GET: /<controller>/
        //public HomeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db, IHostingEnvironment environment)
        //{
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //    _db = db;
        //    _environment = environment;
        //    if (_db.Roles.FirstOrDefault(r => r.Name == "admin") == null)
        //    {
        //        db.Roles.Add(new IdentityRole() { Name = "admin" });
        //    }
        //    if (_db.Roles.FirstOrDefault(r => r.Name == "user") == null)
        //    {
        //        db.Roles.Add(new IdentityRole() { Name = "user" });
        //    }
        //    db.SaveChanges();
        //}


        public IActionResult Index()
        {
            return View();
        }

        
    }
}
