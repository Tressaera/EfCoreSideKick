using DemoStore.WebApi;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoStore.WebApi
{
    [ApiController]
    [EntityValidation]
    [Route("api/[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<Employee?> GetAsync([FromQuery] int employeeId)
        {
            return _service.GetAsync(employeeId, HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<IEnumerable<Employee>> GetListAsync()
        {
            return _service.GetListAsync(HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<PagedResult<Employee>> GetPageAsync([FromQuery] PageParameter page)
        {
            return _service.GetPageAsync(page, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddAsync([FromBody] Employee employee)
        {
            return _service.AddAsync(employee, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddRangeAsync([FromBody] IEnumerable<Employee> employees)
        {
            return _service.AddRangeAsync(employees, HttpContext.RequestAborted);
        }

        [HttpPut]
        public Task<bool> UpdateAsync([FromBody] Employee employee)
        {
            return _service.UpdateAsync(employee, HttpContext.RequestAborted);
        }

        [HttpDelete]
        public Task<bool> DeleteAsync([FromQuery] int employeeId)
        {
            return _service.DeleteAsync(employeeId, HttpContext.RequestAborted);
        }
    }
}
