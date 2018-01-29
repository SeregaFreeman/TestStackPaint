using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStackFramework.framework.elements;

namespace Views
{
    public class MainView
    {
        public static UIItem FileButton => BaseUiItem<TestStack.White.UIItems.Button>.
            Find(TreeScope.Descendants, AutomationElementIdentifiers.NameProperty, "File tab");
    }
}
