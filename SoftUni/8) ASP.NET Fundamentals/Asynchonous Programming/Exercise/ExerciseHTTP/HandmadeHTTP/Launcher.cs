namespace HandmadeHTTP
{
    using Server;
    using Server.Routing;
    using Server.Contracts;
    using GameStoreApplication;
    using HandmadeHTTP.ByTheCake;

    public class Launcher : IRunnable
    {
        public static void Main()
        {
            new Launcher().Run();
        }

        public void Run()
        {
            ////var mainApplication = new GameStoreApp();
            ////var mainApplication = new ByTheCakeApp();
            //mainApplication.InitializeDatabase();

            //var appRouteConfig = new AppRouteConfig();
            //mainApplication.Configure(appRouteConfig);

            //var webServer = new WebServer(1337, appRouteConfig);

            //webServer.Run();
        }
    }
}