using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestStackFramework.framework.elements
{
    class ListBox : BaseUiItem<TestStack.White.UIItems.ListBoxItems.ListBox>
    {
        protected ListBox(TestStack.White.UIItems.ListBoxItems.ListBox uiItem, string itemName) : base(uiItem, itemName)
        {

        }

        public static ListBox Get(SearchCriteria searchCriteria, string itemName, Window window = null)
        {
            return new ListBox(Find(searchCriteria, window), itemName);
        }
    }
}
