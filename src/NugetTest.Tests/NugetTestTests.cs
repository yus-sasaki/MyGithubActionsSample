using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlackNotification;

namespace NugetTest.Tests
{
    [TestClass]
    public class NugetTestTests
    {
        [TestMethod]
        public async Task TestMethod1()
        {
	        var slackNotificationService = new SlackNotificationService();
	        var result = await slackNotificationService.Notify(
		        "Test",
		        "hogehoge",
		        "sasaki_y",
		        "sasaki_y");
	        Assert.IsFalse(result);
        }
    }
}
