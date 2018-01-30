using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStackFramework.framework.elements;

namespace Views
{
    public class ImageView
    {
        public static MenuItem MenuItemSelectAll => MenuItem.Get(SearchCriteria.ByControlType(ControlType.MenuItem).AndByText("Select all"), "Select all");
        public static UIItem ButtonSelect => BaseUiItem<TestStack.White.UIItems.Button>.
            FindItemByIndex(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Select"), 2);
    }
}
