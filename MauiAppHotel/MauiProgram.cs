using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("TASAOrbiter-Bold.ttf", "TASAOrbiterBold");
                    fonts.AddFont("TASAOrbiter-ExtraBold.ttf", "TASAOrbiterExtraBold");
                    fonts.AddFont("TASAOrbiter-Medium.ttf", "TASAOrbiterMedium");
                    fonts.AddFont("TASAOrbiter-Regular.ttf", "TASAOrbiterRegular");
                    fonts.AddFont("TASAOrbiter-SemiBold.ttf", "TASAOrbiterSemiBold");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
