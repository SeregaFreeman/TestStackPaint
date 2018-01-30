using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStackFramework.framework;
using TestStackFramework.framework.elements;

namespace Views
{
    public class MainView
    {
        public static UIItem ButtonFile => BaseUiItem<TestStack.White.UIItems.Button>.
            Find(TreeScope.Descendants, AutomationElementIdentifiers.NameProperty, "File tab");

        public static TestStackFramework.framework.elements.Button ButtonClose =>
            TestStackFramework.framework.elements.Button.Get(SearchCriteria.ByAutomationId("Close"), "Close");

        public static TestStackFramework.framework.elements.Button ButtonDoNotSave =>
            TestStackFramework.framework.elements.Button.Get(SearchCriteria.ByAutomationId("CommandButton_7"), "Don't save changes", Scope.DefaultWindow.ModalWindow("Paint"));
    }
}
