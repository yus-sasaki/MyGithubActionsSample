using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SlackNotification.Tests
{
    [TestClass]
    public class SlackNotificationTests
    {
        [TestMethod]
        public async Task NotifyTest()
        {
            var slackNotificationService = new SlackNotificationService();
            var result = await slackNotificationService.Notify(
                "Test",
                @"https://hooks.slack.com/services/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",
                "sasaki_y",
                "sasaki_y");
            Assert.IsFalse(result);
        }
    }
}
