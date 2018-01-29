using System.Windows.Automation;
using TestStack.White.UIItems.Finders;
using TestStackFramework.framework.elements;

namespace Views
{
    public class FileMenuView
    {
        public static MenuItem OpenMenuItem => MenuItem.Get(SearchCriteria.ByControlType(ControlType.MenuItem).AndByText("Open"), "Open file");
    }
}
