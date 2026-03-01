using MauiPractica.Pages;

namespace MauiPractica
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DetalleEmpleadoPage), typeof(DetalleEmpleadoPage));
        }
    }
}
