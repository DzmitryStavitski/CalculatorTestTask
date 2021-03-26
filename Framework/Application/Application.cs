using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Framework.Application
{
    public class Application
    {
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
            application = TestStack.White.Application.Launch(applicationPath);
            applicationWindow = application.GetWindow(applicationWindowName);
        }

        public void clickButton(string elementText)
        {
            var button = applicationWindow.Get<Button>(SearchCriteria.ByText(elementText));
            if (button != null) button.Click();
        }

        public void clickButton(int elementId)
        {
            var button = applicationWindow.Get<Button>(SearchCriteria.ByAutomationId(elementId.ToString()));
            if (button != null) button.Click();
        }

        public string returnTextFromTheTextBox(int automationId)
        {
            return
                applicationWindow.Get<Label>(SearchCriteria.ByAutomationId(automationId.ToString())).AutomationElement.
                    GetCurrentPropertyValue(System.Windows.Automation.AutomationElement.NameProperty).ToString();
        }

        public void Close()
        {
            application.Close();
        }
    }
}
