using System.Windows.Automation;
using TestStack.White.UIItems.Finders;
using TestStackFramework.framework.elements;

namespace Views
{
    public class FileMenuView
    {
        public static MenuItem MenuItemOpen => MenuItem.Get(SearchCriteria.ByControlType(ControlType.MenuItem).AndByText("Open"), "Open file");
    }
}
