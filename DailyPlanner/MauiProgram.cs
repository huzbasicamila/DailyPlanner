using DailyPlanner.ViewModels;
using DailyPlanner.Views;

namespace DailyPlanner;

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

		builder.Services.AddSingleton<HomePage>();
		builder.Services.AddSingleton<LoginPage>();

		builder.Services.AddSingleton<LoginPageViewModel>();
		return builder.Build();
	}
}
