using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("[action]")]

        public IActionResult ContactUs()
        {
            var contact = new Dictionary<string, string>
            {
                {"Phone:", "555-555-5555" },
                {"Email:", "info@myguitarshop.com"}
            };
            return View(contact);
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }
    }
}
