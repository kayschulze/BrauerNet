using Microsoft.AspNetCore.Mvc;

namespace BrauerNet.Controllers
{
    public class TasksController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
