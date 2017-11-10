using Microsoft.AspNetCore.Mvc;

namespace BrauerNet.Controllers
{
    public class TeamsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
