using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevManager.Controllers
{
    public class TeamController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
