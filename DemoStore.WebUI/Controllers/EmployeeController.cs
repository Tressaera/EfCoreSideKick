using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace DemoStore.WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public EmployeeController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult EmployeeList()
        {

            var _employees = _context.Employees.ToList();
            var employeeModels = _mapper.Map<List<ResultEmployeeDTO>>(_employees);
            return View(employeeModels);
        }
    }
}
