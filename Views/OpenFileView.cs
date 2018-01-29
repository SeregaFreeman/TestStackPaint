using System.Windows.Automation;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStackFramework.framework;
using TestStackFramework.framework.elements;

namespace Views
{
    public class OpenFileView
    {
        private static readonly Window ModalWindow = Scope.DefaultWindow.ModalWindow("Open");

        public static Button OpenButton => Button.Get(SearchCriteria.ByControlType(ControlType.Button).AndByText("Open"), "Open file", ModalWindow);
        public static ToolBar FilePathToolBar => ToolBar.Get(SearchCriteria.ByAutomationId("1001"), "File path");
        public static TextBox TextBoxFilePath => TextBox.Get(SearchCriteria.ByAutomationId("41477"), "Fale path input");

    }
}
