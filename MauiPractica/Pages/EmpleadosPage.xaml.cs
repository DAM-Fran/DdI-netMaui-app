using CommunityToolkit.Mvvm;
using MauiPractica.Models;
using MauiPractica.PageModels;

namespace MauiPractica.Pages;

public partial class EmpleadosPage : ContentPage
{
	public EmpleadosPage(EmpleadosPageModel empleadosPageModel)
	{
        InitializeComponent();
        BindingContext = empleadosPageModel;
    }
    public EmpleadosPage() : this(Resolve<EmpleadosPageModel>()) { }


    private async void OnEmpleadoSeleccionado(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Empleado emp)
        {
            var navParams = new Dictionary<string, object>
        {
            { "empleado", emp }
        };

            await Shell.Current.GoToAsync(nameof(DetalleEmpleadoPage), navParams);
        }
    }

    private static T Resolve<T>() => IPlatformApplication.Current.Services.GetService<T>();

}