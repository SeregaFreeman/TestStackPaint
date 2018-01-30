using System.Drawing;
using System.IO;
using TechTalk.SpecFlow;
using TestStackFramework.framework;
using TestStackFramework.utils;
using Views;

namespace Tests.steps
{
    [Binding]
    public class PaintTestSteps
    {
        [Given(@"All old instances of app were closed")]
        public void GivenAllOldInstancesOfAppAreClosed()
        {
            ProcessesUtil.CloseAllProcessesByName(ConfigUtil.GetConfigValue("processName"));
        }
        
        [Given(@"new instance was open")]
        public void GivenNewInstanceIsOpen()
        {
            Scope.Application = MyApp.Launch();
            Scope.DefaultWindow = MyApp.Window;
        }
        
        [When(@"user opens an image '(.*)' from '(.*)'")]
        public void WhenUserOpensAnImageFrom(string imageName, string imagePath)
        {
            Bitmap initialImage = new Bitmap(Image.FromFile(Path.Combine(imagePath, imageName)));
            ScenarioContext.Current.Add("initialImage", initialImage);
            ScenarioContext.Current.Add("imagePath", Path.Combine(imagePath, imageName));
            MainView.ButtonFile.Click();
            FileMenuView.MenuItemOpen.Click();
            OpenFileView.ToolBarFilePath.Click();
            OpenFileView.TextBoxFilePath.BulkText(imagePath);
            OpenFileView.ListItemImageThumbnail(imageName).Click();
            OpenFileView.ButtonOpenFile.Click();
        }

        [When(@"user cuts all selected image area")]
        public void WhenUserCutsAllSelectedImageArea()
        {
            ImageView.ButtonSelect.Click();
            ImageView.MenuItemSelectAll.RaiseClickEvent();
            ClipboardView.ButtonCut.RaiseClickEvent();
        }

        [When(@"user closes app without applying changes")]
        public void WhenUserClosesAppWithoutApplyingChanges()
        {
            MainView.ButtonClose.Click();
            MainView.ButtonDoNotSave.Click();
        }

        [Then(@"image is not changed\.")]
        public void ThenImageIsNotChanged_()
        {
            AssertionUtil.AssertTrue(
                ImageUtil.ImageCompareString(
                    (Bitmap) ScenarioContext.Current["initialImage"],
                    new Bitmap(Image.FromFile(Path.Combine((string)ScenarioContext.Current["imagePath"])))
                ),
                "Image has changed");
        }

    }
}
