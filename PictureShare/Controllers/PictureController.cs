using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PictureShare.Data;
using PictureShare.Helpers;
using PictureShare.Models;

namespace PictureShare.Controllers
{
    [Authorize]
    public class PictureController : Controller
    {
        private readonly ApplicationDbContext _db;
        private Images _image;

        public PictureController(ApplicationDbContext db, Images image)
        {
            _db = db;
            _image = image;
        }

        public async Task<IActionResult> Index()
        {
            var pictures = await _db.Pictures.ToListAsync();
            return View(pictures);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PictureModel model)
        {
            model.Timestamp = DateTime.Now;
            model.UserEmail = User.Identity.Name;

            //HERE

            return View();
        }
    }
}
