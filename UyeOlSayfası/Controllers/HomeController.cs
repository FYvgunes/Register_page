using Microsoft.AspNetCore.Mvc;

namespace UyeOlSayfası.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}