using PGS.Domain.Abstract;
using PGS.Domain.Entities;
using System.Web.Mvc;

namespace PGS.WebUI.Controllers
{
    public class HomeController : Controller
    {       
        private IUserRepository repository;

        public HomeController (IUserRepository repo)
        {
            repository = repo;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult CreateUser()
        {      
            return View(new User());
        }

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                repository.SaveUser(user);
                return RedirectToAction("ShowUser", user);
            }
            else
                return View(user);
        }

        public ActionResult ShowUser(User user)
        {
            return View(user);
        }
    }
}