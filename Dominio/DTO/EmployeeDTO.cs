using System.Text.Json.Serialization;

namespace Dominio.DTO
{
    public class EmployeeDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("employee_name")]
        public string EmployeeName { get; set; }

        [JsonPropertyName("employee_salary")]
        public int EmployeeSalary { get; set; }

        [JsonPropertyName("employee_age")]
        public int EmployeeAge { get; set; }

        [JsonPropertyName("profile_image")]
        public string ProfileImage { get; set; }
        [JsonPropertyName("employee_anual_salary")]
        public int? EmployeeAnualSalary { get; set; }
    }
}
