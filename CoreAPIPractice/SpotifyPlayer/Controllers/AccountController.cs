using System;
using System.Net.Http;
using System.Web.Mvc;

namespace SpotifyPlayer.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAuthorize()
        {
            using(var client = new HttpClient())
            {
            }
            return View();
        }
        public ActionResult Callback(string code, string state)
        {
            return RedirectToAction("Index", "Home", new { code = code });
        }
    }
}
