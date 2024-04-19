using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(u => u.WillAttend == true).Count();
            return View("Thanks", model);
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }
    }
}