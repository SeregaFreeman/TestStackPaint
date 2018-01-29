using TestStackFramework.framework;
using TechTalk.SpecFlow;

namespace Tests.hooks
{
    [Binding]
    public class BeforeAfterScenario
    {
        [AfterScenario]
        public void CloseApp()
        {
            Scope.Application.Kill();
        }
    }
}
