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
                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                    fonts.AddFont("PTSerif-Bold.ttf", "PTSerifBold");
                    fonts.AddFont("PTSerif-BoldItalic.ttf", "PTSerifBoldItalic");
                    fonts.AddFont("PTSerif-Italic..ttf", "PTSerifItalic.");
                    fonts.AddFont("PTSerif-Regular.ttf", "PTSerifRegular");
                    fonts.AddFont("PlayfairDisplaySC-Black.ttf", "PlayfairDisplaySCBlack");
                    fonts.AddFont("PlayfairDisplaySC-BlackItalic.ttf", "PlayfairDisplaySCBlackItalic");
                    fonts.AddFont("PlayfairDisplaySC-Bold.ttf", "PlayfairDisplaySCBold");
                    fonts.AddFont("PlayfairDisplaySC-BoldItalic.ttf", "PlayfairDisplaySCBoldItalic");
                    fonts.AddFont("PlayfairDisplaySC-Italic.ttf", "PlayfairDisplaySCItalic");
                    fonts.AddFont("PlayfairDisplaySC-Regular.ttf", "PlayfairDisplaySCRegular");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
