using MauiPractica.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace MauiPractica.Services;

public class ApiService : IApiService
{
    HttpClient _client = new HttpClient();
    JsonSerializerOptions _serializerOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    Uri baseUri = new(string.Format("http://127.0.0.1:8000"));

    public async Task<List<Empleado>> GetEmpleadosAsync() => await _client.GetFromJsonAsync<List<Empleado>>(baseUri + "/empleados/");
    /*
    public async Task<List<Empleado>> GetEmpleadosAsync()
    {
        return new List<Empleado>
    {
        new Empleado { Id = 1, Nombre = "Test" }
    };
    }
    */

    public async Task<List<Departamento>> GetDepartamentosAsync() => await _client.GetFromJsonAsync<List<Departamento>>(baseUri + "/departamentos/");
}
