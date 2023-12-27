using Microsoft.AspNetCore.Components.Infrastructure;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using MangaReader.Shared.Service;

namespace MangaReader
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
            builder.Services.AddHttpClient();
            builder.Services.AddScoped<AppService>();

            //builder.Services.AddScoped<ListenTogetherHubClient>(_ =>
            //    new ListenTogetherHubClient(ListenTogetherUrl));
            builder.Services.AddScoped<ComponentStatePersistenceManager>();
            builder.Services.AddScoped<PersistentComponentState>(sp => sp.GetRequiredService<ComponentStatePersistenceManager>().State);


            builder.Services.AddMudServices();
            return builder.Build();
        }
    }
}
