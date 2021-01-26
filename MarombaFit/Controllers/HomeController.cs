using MarombaFit.Models;
using System.Web.Mvc;

namespace MarombaFit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Usuario usuario = new Usuario();
            usuario.Name = "Maromba Fit";
            return View(usuario);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}