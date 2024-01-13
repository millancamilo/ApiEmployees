using Dominio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Interfaz
{
    public interface ILogicEmployee
    {
        Task<ResponseDTO<List<EmployeeDTO>>> GetEmployeesAsync();
        Task<ResponseDTO<EmployeeDTO>> GetEmployeesAsyncById(int id);
    }
}
