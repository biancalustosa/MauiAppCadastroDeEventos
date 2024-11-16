using Microsoft.Extensions.Logging;

namespace MauiAppCadastroDeEventos;

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

				fonts.AddFont("Merriweather-Black.ttf", "MerriweatherBlack");
				fonts.AddFont("Merriweather-BlackItalic.ttf", "MerriweatherBlackItalic");
				fonts.AddFont("Merriweather-Bold.ttf", "MerriweatherBold");
				fonts.AddFont("Merriweather-BoldItalic.ttf", "MerriweatherBoldItalic");
				fonts.AddFont("Merriweather-Italic.ttf", "MerriweatherItalic");
				fonts.AddFont("Merriweather-Light.ttf", "MerriweatherLight");
				fonts.AddFont("Merriweather-LightItalic.ttf", "MerriweatherLightItalic");
				fonts.AddFont("Merriweather.ttf", "Merriweather");

			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
