using System.Windows.Automation;
using TestStack.White.UIItems.Finders;
using TestStackFramework.framework.elements;

namespace Views
{
    class ClipboardView
    {
        public static Button CutButton =>
            Button.Get(SearchCriteria.ByControlType(ControlType.Button).AndByText("Cut"), "Cut button");
    }
}
