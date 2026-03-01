using MauiPractica.Models;

namespace MauiPractica.Services;

public interface IApiService
{
    public Task<List<Empleado>> GetEmpleadosAsync();
    public Task<List<Departamento>> GetDepartamentosAsync();
}
