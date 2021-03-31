using Framework.Application;
using Framework.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;

namespace CalculatorSpecFlowTests.pages
{
    public class Calculator
    {
        public static Application application = Application.GetApplication();

        private TextBox resultBox = new TextBox(SearchCriteria.ByAutomationId("150"));
        private Button addButton = new Button(SearchCriteria.ByAutomationId("93"));
        private Button equalsButton = new Button(SearchCriteria.ByAutomationId("121"));
        private Button memoryAddButton = new Button(SearchCriteria.ByAutomationId("125"));
        private Button memoryRecallButton = new Button(SearchCriteria.ByAutomationId("123"));

        public void ChangeView(string view)
        {
            BaseElement.ClickOnMenu("View", view);
        }

        public string GetResult()
        {
            return resultBox.returnText();
        }

        public void ClickEqualsButton()
        {
            equalsButton.Click();
        }

        public void ClickMemoryAddButton()
        {
            memoryAddButton.Click();
        }

        public void ClickMemoryRecallButton()
        {
            memoryRecallButton.Click();
        }

        public void ClickAddButton()
        {
            addButton.Click();
        }

        public void EnterNumber(int number)
        {
            string result = number.ToString();
            var list = result.Select(digit => int.Parse(digit.ToString()));

            foreach (int digit in list)
            {
                var button = new Button(SearchCriteria.ByText(digit.ToString()));
                button.Click();
            }
        }

        public bool IsOpen()
        {
            return resultBox.Exists();
        }
    }
}
