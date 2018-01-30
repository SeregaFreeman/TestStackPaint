using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStackFramework.framework;
using TestStackFramework.framework.elements;
using Button = TestStackFramework.framework.elements.Button;
using TextBox = TestStackFramework.framework.elements.TextBox;

namespace Views
{
    public class OpenFileView
    {
        private static readonly Window ModalWindow = Scope.DefaultWindow.ModalWindow("Open");

        public static Button ButtonOpenFile => Button.Get(SearchCriteria.ByControlType(ControlType.Button).AndByText("Open"), "Open file", ModalWindow);
        public static ToolBar ToolBarFilePath => ToolBar.Get(SearchCriteria.ByAutomationId("1001"), "File path");
        public static TextBox TextBoxFilePath => TextBox.Get(SearchCriteria.ByAutomationId("41477"), "File path input");
        public static UIItem ListItemImageThumbnail(string imageName) => BaseUiItem<TestStack.White.UIItems.ListBoxItems.ListItem>.
            Find(TreeScope.Descendants, AutomationElementIdentifiers.NameProperty, imageName);
    }
}
