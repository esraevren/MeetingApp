using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";

            var  info = new MeetingInfo(){
                Id = 1,
                Location = "Online",
                Date = new DateTime(2024, 1, 20)
            };
            return View();
        }
    }
}