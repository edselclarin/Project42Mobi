using Microsoft.AspNetCore.Components.WebView.Maui;
using Project42Mobi.Data;

namespace Project42Mobi;

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
#endif

		// Add services to the container.
		//builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddSingleton<ClipboardService>();
		builder.Services.AddSingleton<PasswordGeneratorService>();

		return builder.Build();
	}
}
