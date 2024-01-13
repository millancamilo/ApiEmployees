using Dominio.DTO;
using Logica.Interfaz;
using Microsoft.AspNetCore.Mvc;
using Repositorio.Interfaz;

namespace ApiEmployees.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogicEmployee _logicEmployee;

        public EmployeeController(ILogicEmployee logicEmployee)
        {
            _logicEmployee = logicEmployee;
        }

        [HttpGet("employees")]
        public async Task<ActionResult<List<EmployeeDTO>>> GetEmployees()
        {
            var employees = await _logicEmployee.GetEmployeesAsync();
            return Ok(employees);
        }

        [HttpGet("employee/{id}")]
        public async Task<ActionResult<EmployeeDTO>> GetEmployeeById(int id)
        {
            var employee = await _logicEmployee.GetEmployeesAsyncById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
