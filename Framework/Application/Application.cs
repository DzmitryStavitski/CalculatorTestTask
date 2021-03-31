using NLog;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using System;

namespace Framework.Application
{
    public class Application
    {
        private static Application instance;
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        private static TestStack.White.Application application;
        private static Window applicationWindow;
        private static string applicationPath = @"C:\Windows\System32\calc1.exe";
        private static string applicationWindowName = "Калькулятор";

        private Application()
        {}

        public static Application GetApplication()
        {
            if(instance == null)
            {
                instance = new Application();
            }
            return instance;
        }

        public void Run()
        {
            logger.Debug($"Starting Application (Path = {applicationPath}, Window Name = {applicationWindowName})");

            application = TestStack.White.Application.Launch(applicationPath);
            applicationWindow = application.GetWindow(applicationWindowName);

            logger.Info("Application is running...");
        }

        public void Close()
        {
            logger.Debug($"Closing the application");

            application.Close();
            application.Dispose();

            logger.Info($"Application was closed");
        }

        public Window getApplicationWindow()
        {
            return applicationWindow;
        }
     }
}
