using Microsoft.AspNetCore.Mvc;

namespace TopPlanetas.Controllers
{
    public class PaginaPrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
