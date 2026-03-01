using MauiPractica.PageModels;
using MauiPractica.Pages;
using MauiPractica.Services;
using Microsoft.Extensions.Logging;

namespace MauiPractica
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
            //builder.Services.AddSingleton<ILoggerFactory>();  // aquí se inyectan las dependencias
#endif
            builder.Services.AddTransient<MainPage>();

            builder.Services.AddSingleton<IApiService, ApiService>();

            builder.Services.AddTransient<EmpleadosPageModel>();
            builder.Services.AddTransient<EmpleadosPage>();
            builder.Services.AddTransient<DepartamentosPageModel>();
            builder.Services.AddTransient<DepartamentosPage>();
            builder.Services.AddTransient<DetalleEmpleadoPage>();
            builder.Services.AddTransient<DetalleEmpleadoPageModel>();

            /*
            builder.Services.AddTransient<MainPageModel>();
            builder.Services.AddTransient<AboutPage>();
            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<DetailPageModel>();
            */

            return builder.Build();
        }
    }
}
