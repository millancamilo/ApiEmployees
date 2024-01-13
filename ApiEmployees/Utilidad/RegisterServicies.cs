using Logica.Implementacion;
using Logica.Interfaz;
using Repositorio.Implementacion;
using Repositorio.Interfaz;

namespace ApiEmployees.Utilidad
{
    public static class RegisterServicies
    {
        public static IServiceCollection Register(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<IEmployeeDataService, EmployeeDataService>();
            services.AddScoped<ILogicEmployee, LogicEmployee>();
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200");
                });
            });
            return services;
        }
    }
}
