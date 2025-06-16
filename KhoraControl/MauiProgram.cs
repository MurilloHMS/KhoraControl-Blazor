using System.Diagnostics;
using KhoraControl.Domain;
using KhoraControl.Infrastructure.Interfaces;
using KhoraControl.Infrastructure.Repositories;
using KhoraControl.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;

namespace KhoraControl
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            // Register Database
            string dbPath = Path.Combine(AppContext.BaseDirectory, "ControleDeValidades.db");
            Debug.WriteLine($"Caminho do banco: {dbPath}");


            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite($"Data Source={dbPath}"));

            // Register services
            builder.Services.AddMudServices();
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped<ProdutoService>();



            return builder.Build();
        }
    }
}
