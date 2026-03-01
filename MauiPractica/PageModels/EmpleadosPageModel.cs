using CommunityToolkit.Mvvm.ComponentModel;
using MauiPractica.Models;
using MauiPractica.Services;

namespace MauiPractica.PageModels;

public partial class EmpleadosPageModel : ObservableObject
{
    private readonly IApiService _apiService;

    public EmpleadosPageModel(IApiService apiService)
    {
        _apiService = apiService;
        _ = LoadEmpleados(); // no bloquea, no peta
    }

    [ObservableProperty]
    private List<Empleado> empleados;

    private async Task LoadEmpleados()
    {
        Empleados = await _apiService.GetEmpleadosAsync();
    }
}
