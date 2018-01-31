using System.Windows.Automation;
using TestStack.White;
using NUnit.Framework;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStackFramework.utils;

namespace TestStackFramework.framework.elements
{
    public class BaseUiItem<T> where T : UIItem
    {
        private string _itemName;
        protected static T _uiItem;

        public string Name => _uiItem.Name;
        public string ItemName => _itemName;

        public BaseUiItem(T uiItem, string name)
        {
            _uiItem = uiItem;
            _itemName = name;
        }


        public static T Find(SearchCriteria searchCriteria, Window window = null)
        {
            if (window == null)
            {
                window = Scope.DefaultWindow;
            }

            try
            {
                _uiItem = window.Get<T>(searchCriteria);
                LoggerUtil.Info($"Element {_uiItem.Name} is found");
                return _uiItem;
            }
            catch (AutomationException ex)
            {
                LoggerUtil.Error($"Element is not found: {ex}");
            }

            Assert.NotNull(_uiItem, "Element is not found");
            return _uiItem;
        }

        public static UIItem Find(TreeScope treeScope, AutomationProperty property, object value, Window window = null)
        {
            if (window == null)
            {
                window = Scope.DefaultWindow;
            }

            UIItem element =
                new UIItem(window.AutomationElement.FindFirst(treeScope, new PropertyCondition(property, value)),
                    new NullActionListener());
            AssertionUtil.AssertNotNull(element, "Element is not found");
            LoggerUtil.Info($"Element {element.Name} is found");
            return element;
        }

        public static UIItem FindItemByIndex(TreeScope treeScope, Condition condition, int index)
        {
            var elements = Scope.DefaultWindow.AutomationElement.FindAll(treeScope, condition);
            UIItem element = null;
            for (var i = 0; i < elements.Count; i++)
            {
                if (i == index)
                {
                    element = new UIItem(elements[i], new NullActionListener());
                }
            }
            AssertionUtil.AssertNotNull(element, "Element is not found");
            LoggerUtil.Info($"Element {element.Name} is found");
            return element;
        }

        public void Click()
        {
            LoggerUtil.Info($"Clicking {_uiItem.Name}");
            _uiItem.Click();
            
        }

        public void RaiseClickEvent()
        {
            LoggerUtil.Info($"RaiseClicking {_uiItem.Name}");
            _uiItem.RaiseClickEvent();
        }

    }
}
