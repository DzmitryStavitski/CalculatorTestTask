using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Framework.Elements
{
    public class TextBox : BaseElement
    {
        public TextBox(Application.Application application, int elementID)
           : base(application, elementID)
        {

        }

        public override void click()
        {
            logger.Debug($"Clicking on Button (element ID = {elementID})");

            var button = application.getApplicationWindow().Get<TestStack.White.UIItems.TextBox>(SearchCriteria.ByAutomationId(elementID.ToString()));
            if (button != null) button.Click();

            logger.Info($"Click On Button was success");
        }

        public string returnText()
        {
            logger.Debug($"Returning text from TextBox (element ID = {elementID})");

            return
                application.getApplicationWindow().Get<Label>(SearchCriteria.ByAutomationId(elementID.ToString())).AutomationElement.
                    GetCurrentPropertyValue(System.Windows.Automation.AutomationElement.NameProperty).ToString();
        }
    }
}
