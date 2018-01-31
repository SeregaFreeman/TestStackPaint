using NUnit.Framework;

namespace TestStackFramework.utils
{
    public class AssertionUtil
    {
        public static void AssertTrue(bool condition, string message)
        {
            try
            {
                Assert.True(condition, message);
                LoggerUtil.Info("Condition is true");
            }
            catch (AssertionException ex)
            {
                LoggerUtil.Error($"Expected 'true', found {condition}" + ex);
                Assert.Fail();
            }
        }

        public static void AssertNotNull(object targetObject, string message)
        {
            try
            {
                Assert.NotNull(targetObject, message);
                LoggerUtil.Info("Object is not null");
            }
            catch (AssertionException ex)
            {
                LoggerUtil.Error($"Expected object is not null, but found: {ex}");
                Assert.Fail();
            }
        }
    }
}
