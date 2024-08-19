using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_RazorPages.Areas.Candidate.Controllers
{
    [Area("Candidate")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
