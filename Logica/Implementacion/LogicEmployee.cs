using Dominio.DTO;
using Logica.Interfaz;
using Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Implementacion
{
    public class LogicEmployee : ILogicEmployee
    {
        private readonly IEmployeeDataService _employeeDataService;

        int countMonths = 12;
        public LogicEmployee(IEmployeeDataService employeeDataService)
        {
            _employeeDataService = employeeDataService;
        }

        public async Task<ResponseDTO<List<EmployeeDTO>>> GetEmployeesAsync()
        {
            var responseDTO = await _employeeDataService.GetEmployeesAsync();
            foreach (var item in responseDTO.Data)
            {
                item.EmployeeAnualSalary = item.EmployeeSalary * countMonths;
            }
            return responseDTO;
        }

        public async Task<ResponseDTO<EmployeeDTO>> GetEmployeesAsyncById(int id)
        {
            var responseDTO = await _employeeDataService.GetEmployeeByIdAsync(id);
            
            responseDTO.Data.EmployeeAnualSalary = responseDTO.Data.EmployeeSalary * countMonths;
            
            return responseDTO;
        }
    }
}
