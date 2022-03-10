using FoosballScoreboard.BusinessLogic.Interfaces;
using FoosballScoreboard.BusinessLogic.MatchLoader;
using FoosballScoreboard.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FoosballScoreboard.Forms;
internal static class Program
{
    public static IConfiguration? Configuration;
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true); 
        Configuration = builder.Build();

        

        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var services = new ServiceCollection();
        services.Configure<FoosScoreboardSettings>(Configuration.GetSection(FoosScoreboardSettings.SectionName));
        services.AddOptions();

        ConfigureServices(services);

        using ServiceProvider serviceProvider = services.BuildServiceProvider();
        var mainInstance = serviceProvider.GetRequiredService<Main>();
        Application.Run(mainInstance);
    }

    private static void ConfigureServices(ServiceCollection services)
    {

        services.AddScoped<Main>()
            .AddScoped<IMatchLoader, FileMatchLoader>() ;
            
    }
}
