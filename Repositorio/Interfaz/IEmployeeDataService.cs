using Dominio.DTO;

namespace Repositorio.Interfaz
{
    public interface IEmployeeDataService
    {
        Task<ResponseDTO<List<EmployeeDTO>>> GetEmployeesAsync();
        Task<ResponseDTO<EmployeeDTO>> GetEmployeeByIdAsync(int id);
    }
}
