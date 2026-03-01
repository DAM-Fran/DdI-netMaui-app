using CommunityToolkit.Mvvm.ComponentModel;
using MauiPractica.Models;
using MauiPractica.Services;

namespace MauiPractica.PageModels;

public partial class DepartamentosPageModel : ObservableObject
{
    private readonly IApiService _apiService;

    public DepartamentosPageModel(IApiService apiService)
    {
        _apiService = apiService;
        _ = LoadDepartamentos();
    }

    [ObservableProperty]
    private List<Departamento> departamentos;

    private async Task LoadDepartamentos()
    {
        Departamentos = await _apiService.GetDepartamentosAsync();
    }
}
