using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Framework.Elements
{
    public class Button : BaseElement
    {
       public Button(Application.Application application, int elementID)
            : base(application, elementID)
        {
            
        }

       public override void click()
        {
            logger.Debug($"Clicking on Button (element ID = {elementID})");

            var button = application.getApplicationWindow().Get<TestStack.White.UIItems.Button>(SearchCriteria.ByAutomationId(elementID.ToString()));
            if (button != null) button.Click();

            logger.Info($"Click On Button was success");
        }
    }
}
