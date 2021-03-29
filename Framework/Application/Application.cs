using NLog;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using System;

namespace Framework.Application
{
    public class Application
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        private TestStack.White.Application application;
        private Window applicationWindow;
        private string applicationPath;
        private string applicationWindowName;

        public Application(string applicationPath, string applicationWindowName)
        {
            this.applicationPath = applicationPath;
            this.applicationWindowName = applicationWindowName;
        }

        public void Run()
        {
            logger.Debug($"Starting Application (Path = {applicationPath}, Window Name = {applicationWindowName})");

            application = TestStack.White.Application.Launch(applicationPath);
            applicationWindow = application.GetWindow(applicationWindowName);

            logger.Info("Application is running...");
        }

        public Elements.Button FindButtonByText(string elementText)
        {
            logger.Debug($"Returning button (with text = {elementText})");

            var button = applicationWindow.Get<Button>(SearchCriteria.ByText(elementText));
            return new Elements.Button(this, Int32.Parse(button.Id));
        }

        public Elements.TextBox FindTextBoxByText(string elementText)
        {
            logger.Debug($"Returning button (with text = {elementText})");

            var button = applicationWindow.Get<TextBox>(SearchCriteria.ByText(elementText));
            return new Elements.TextBox(this, Int32.Parse(button.Id));
        }

        public void MenuItemClick(string menuName, string itemName)
        {
            logger.Debug($"Returning menuItem (with path = {menuName} -> {itemName})");
            var menu = applicationWindow.MenuBar.MenuItem(menuName, itemName);
            menu.Click();
        }

        public void Close()
        {
            logger.Debug($"Closing the application");

            application.Close();

            logger.Info($"Application was closed");
        }

        public Window getApplicationWindow()
        {
            return applicationWindow;
        }
     }
}
