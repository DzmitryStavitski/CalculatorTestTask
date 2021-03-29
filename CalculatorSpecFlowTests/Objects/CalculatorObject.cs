using Framework.Application;
using Framework.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSpecFlowTests.Objects
{
    class CalculatorObject
    {
        Application application = new Application(@"C:\Windows\System32\calc1.exe", "Calculator");

        private TextBox resultBox;
        private Button addButton;
        private Button equalsButton;
        private Button memoryAddButton;
        private Button memoryRecallButton;

        public CalculatorObject()
        {
            resultBox = new TextBox(application, 150);
            addButton = new Button(application, 93);
            equalsButton = new Button(application, 121);
            memoryAddButton = new Button(application, 125);
            memoryRecallButton = new Button(application, 123);
            application.Run();
        }

        public void changeView(string view)
        {
            application.MenuItemClick("View", view);
        }

        public string getResult()
        {
            return resultBox.returnText();
        }

        public void ClickEqualsButton()
        {
            equalsButton.click();
        }

        public void ClickMemoryAddButton()
        {
            memoryAddButton.click();
        }

        public void ClickMemoryRecallButton()
        {
            memoryRecallButton.click();
        }

        public void ClickAddButton()
        {
            addButton.click();
        }

        public void EnterNumber(int number)
        {
            string result = number.ToString();
            var list = result.Select(digit => int.Parse(digit.ToString()));

            foreach (int digit in list)
            {
                application.FindButtonByText(digit.ToString()).click();
            }
        }

        public bool IsOpen()
        {
            return application != null;
        }

        public void Close()
        {
            application.Close();
        }
    }
}
