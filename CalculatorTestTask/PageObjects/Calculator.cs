using System.Collections.Generic;
using System.Linq;
using Framework.Application;

namespace CalculatorTestTask.PageObjects
{
    class Calculator
    {
        Application application = new Application(@"C:\Windows\System32\calc1.exe", "Calculator");

        private int resultTextBoxId = 150;
        private int equalsButtonId = 121;
        private int memoryAddButtonId = 125;
        private int memoryRecallButtonId = 123;
        private int addButtonId = 93;

        public Calculator()
        {
            application.Run();
        }

        public string getResult()
        {
            return application.returnTextFromTheTextBox(resultTextBoxId);
        }

        public void ClickEqualsButton()
        {
            application.clickButton(equalsButtonId);
        }

        public void ClickMemoryAddButton()
        {
            application.clickButton(memoryAddButtonId);
        }

        public void ClickMemoryRecallButton()
        {
            application.clickButton(memoryRecallButtonId);
        }

        public void ClickAddButton()
        {
            application.clickButton(addButtonId);
        }

        public void EnterNumber(int number)
        {
            string result = number.ToString();
            var list = result.Select(digit => int.Parse(digit.ToString()));
            
            foreach (int digit in list)
            {
                application.clickButton(digit.ToString());
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
