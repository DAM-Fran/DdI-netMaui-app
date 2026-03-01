using CommunityToolkit.Mvvm.ComponentModel;
using MauiPractica.Models;

namespace MauiPractica.PageModels;

public partial class DetalleEmpleadoPageModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    private Empleado empleado;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("empleado"))
            Empleado = query["empleado"] as Empleado;
    }
}
