using Microsoft.AspNetCore.Mvc;

namespace portfolio
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult contact()
        {
            return View();
        }
    }
}