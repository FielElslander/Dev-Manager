using DHTMLX.Scheduler;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevManager.Controllers
{
    public class AgendaController : Controller
    {

        [Authorize]
        public IActionResult Index()
        {

            return View();
        }
    }
}
