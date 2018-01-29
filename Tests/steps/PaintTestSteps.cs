using System.Threading;
using TechTalk.SpecFlow;
using TestStackFramework;
using TestStackFramework.framework;
using TestStackFramework.utils;
using Views;

namespace Tests.steps
{
    [Binding]
    public class PaintTestSteps
    {
        [Given(@"All old instances of app are closed")]
        public void GivenAllOldInstancesOfAppAreClosed()
        {
            ProcessesUtil.CloseAllProcessesByName(Settings.Default.processName);
        }
        
        [Given(@"new instance is open")]
        public void GivenNewInstanceIsOpen()
        {
            Scope.Application = MyApp.Launch();
            Scope.DefaultWindow = MyApp.Window;
        }
        
        [When(@"user opens an image '(.*)' from '(.*)'")]
        public void WhenUserOpensAnImageFrom(string imageName, string imagePath)
        {
            MainView.FileButton.Click();
            FileMenuView.OpenMenuItem.Click();
            Thread.Sleep(1000);
            OpenFileView.FilePathToolBar.Click();
            OpenFileView.TextBoxFilePath.BulkText(imagePath);
            Thread.Sleep(1000);
            OpenFileView.OpenButton.Click();
            Thread.Sleep(1000);
        }
    }
}
