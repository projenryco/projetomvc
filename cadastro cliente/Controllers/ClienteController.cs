using Microsoft.AspNetCore.Mvc;

namespace cadastro_cliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
