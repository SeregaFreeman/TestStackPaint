using TestStack.White.UIItems.Finders;
using TestStackFramework.framework.elements;

namespace Views
{
    public class ClipboardView
    {
        public static Button ButtonCut =>
            Button.Get(SearchCriteria.ByText("Cut"), "Cut");
    }
}
