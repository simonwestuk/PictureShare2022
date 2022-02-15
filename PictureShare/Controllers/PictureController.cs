using Microsoft.AspNetCore.Mvc;

namespace PictureShare.Controllers
{
    public class PictureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
