using Dominio.DTO;
using Repositorio.Interfaz;
using System.Net.Http.Json;
using System.Text.Json;

namespace Repositorio.Implementacion
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient _httpClient;

        public EmployeeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDTO<List<EmployeeDTO>>> GetEmployeesAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("http://dummy.restapiexample.com/api/v1/employees");
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync(); 
                
                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };
                var employeesResponse = JsonSerializer.Deserialize<ResponseDTO<List<EmployeeDTO>>>(jsonContent, options);


                return employeesResponse;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public async Task<ResponseDTO<EmployeeDTO>> GetEmployeeByIdAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"http://dummy.restapiexample.com/api/v1/employee/{id}");
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };
                var employee = JsonSerializer.Deserialize<ResponseDTO<EmployeeDTO>>(jsonContent, options);


                return employee;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
