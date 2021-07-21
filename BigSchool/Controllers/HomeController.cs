
using System.Data.Entity;
using BigSchool.Models;
using BigSchool.ViewModels;
using System.Web.Mvc;
using System.Linq;
using System;

namespace BigSchool.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var upcomingCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);

            var viewMoldel = new Class1
            {
                upcommingcourses = upcomingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };

            return View(viewMoldel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}