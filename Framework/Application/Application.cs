using NLog;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Framework.Application
{
    public class Application
    {
        private static ILogger logger =  Logger.Logger.getLogger();
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

        public void clickButton(string elementText)
        {
            logger.Debug($"Clicking on Button (with text = {elementText})");

            var button = applicationWindow.Get<Button>(SearchCriteria.ByText(elementText));
            if (button != null) button.Click();

            logger.Info($"Click On Button was success");
        }

        public void clickButton(int elementId)
        {
            logger.Debug($"Clicking on Button (element ID = {elementId})");

            var button = applicationWindow.Get<Button>(SearchCriteria.ByAutomationId(elementId.ToString()));
            if (button != null) button.Click();

            logger.Info($"Click On Button was success");
        }

        public string returnTextFromTheTextBox(int automationId)
        {
            logger.Debug($"Returning text from TextBox (element ID = {automationId})");

            return
                applicationWindow.Get<Label>(SearchCriteria.ByAutomationId(automationId.ToString())).AutomationElement.
                    GetCurrentPropertyValue(System.Windows.Automation.AutomationElement.NameProperty).ToString();

            logger.Info($"Returning text was success");
        }

        public void Close()
        {
            logger.Debug($"Closing the application");

            application.Close();

            logger.Info($"Application was closed");
        }
    }
}
