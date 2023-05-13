global using MauiBlazorBlogApp.Models;
global using MauiBlazorBlogApp.Services;
global using System.Xml;
global using System.ServiceModel.Syndication;

using Microsoft.Extensions.Logging;
using MauiBlazorBlogApp.Data;

namespace MauiBlazorBlogApp;

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

		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
