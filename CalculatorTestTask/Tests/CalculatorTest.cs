using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Automation;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;


namespace CalculatorTest
{
    [TestClass]
    class UnitTest1
    {
        private static Application application;

        [TestMethod]
        public void AddTwoNumbers()
        {
            application = Application.Launch(@"C:\Windows\System32\calc112.exe");
            Assert.IsNotNull(application);

            GetButton("1").Click();
            GetButton("2").Click();
            GetButton("Add").Click();
            GetButton("9").Click();
            GetButton("9").Click();
            GetButton("9").Click();
            GetButton("Equals").Click();
            GetButton("Memory add").Click();
            GetButton("1").Click();
            GetButton("9").Click();
            GetButton("Add").Click();
            GetButton("Memory recall").Click();
            GetButton("Equals").Click();

            Assert.AreEqual("1030", ResultTextBox());
            application.Close();
        }

        private static Button GetButton(string elementText)
        {
            for (var i = 0; i < 100; i++)
            {
                var button = GetWindow().Get<Button>(SearchCriteria.ByText(elementText));
                if (button != null) return button;
            }

            return null;
        }

        private static Window GetWindow()
        {
            return application.GetWindow("Calculator");
            
        }

        private static string ResultTextBox()
        {
            return
                GetWindow().Get<Label>(SearchCriteria.ByAutomationId("150")).AutomationElement.
                    GetCurrentPropertyValue(AutomationElement.NameProperty).ToString();
        }
    }
}
