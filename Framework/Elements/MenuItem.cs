using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;

namespace Framework.Elements
{
    public class MenuItem : BaseElement
    {
        public MenuItem(Application.Application application, int elementID)
            : base(application, elementID)
        {

        }
        public override void click()
        {
            logger.Debug($"Clicking on Button (element ID = {elementID})");
        }
    }
}
