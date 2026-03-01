using MauiPractica.PageModels;

namespace MauiPractica.Pages;

public partial class DetalleEmpleadoPage : ContentPage
{
    public DetalleEmpleadoPage(DetalleEmpleadoPageModel detalleEmpleadoPageModel)
    {
        InitializeComponent();
        BindingContext = detalleEmpleadoPageModel;
    }
}
