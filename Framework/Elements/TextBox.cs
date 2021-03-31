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
        public TextBox(SearchCriteria criteria)
           : base(criteria)
        {

        }

        public string returnText()
        {
            logger.Debug($"Returning text from TextBox (element ID = {elementID})");

            return
                application.getApplicationWindow().Get<Label>(criteria).AutomationElement.
                    GetCurrentPropertyValue(System.Windows.Automation.AutomationElement.NameProperty).ToString();
        }
    }
}
