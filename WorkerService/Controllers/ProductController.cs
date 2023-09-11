using Microsoft.AspNetCore.Mvc;

namespace WorkerService.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
