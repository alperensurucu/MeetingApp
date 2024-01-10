using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            //ViewBag.selamlama = saat > 12 ? "İyi Günler" : "Günaydın"; // Böyle de yapılabilir.
            //ViewBag.Username = "Alperen";

            ViewData["selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";  // Böyle de.
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            // ViewData["Username"] = "Alperen";

            var meetingInfo = new MeetingInfo()
            {
                id = 1,
                Location = "İstanbul,Ataşehir Kayışdağı kongre merezi",
                Date = new DateTime(2024, 01, 29, 20, 0, 0),
                NumberOfPeople = UserCount
            
            };

            return View(meetingInfo);
        }
    }
}
