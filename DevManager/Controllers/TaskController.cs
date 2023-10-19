using AutoMapper;
using DevManager.Service;
using DevManager.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevManager.Controllers
{
    public class TaskController : Controller
    {
        private readonly IMapper _mapper;
        private readonly AssignmentService _assignmentService;

        public TaskController(AssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            try
            {
                var taakList = await _assignmentService.GetAll();
                List<AssignmentVM> taakVMList = new List<AssignmentVM>();
                taakVMList = _mapper.Map<List<AssignmentVM>>(taakList);
                return View(taakVMList);
            }
            catch(Exception ex)
            {
                throw new Exception("error in TaskController, index()", ex);
            }
        }
    }
}
