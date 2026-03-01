using MauiPractica.PageModels;

namespace MauiPractica.Pages;

public partial class DepartamentosPage : ContentPage
{
	public DepartamentosPage(DepartamentosPageModel departamentosPageModel)
	{
        InitializeComponent();
        BindingContext = departamentosPageModel;
	}
}