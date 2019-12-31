using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UI_TestSuite
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        [Category("Some category")]
        public void WelcomeTextIsDisplayed()
        {
            // Arrange
            var results = app.WaitForElement("ItemsListView");
            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            app.Screenshot("Welcome screen.");
            //app.EnterText();

            // Act
            //app.Tap();

            // Assert
            //app.Query();
            Assert.IsTrue(results.Any());
        }

        [Test]
        [Category("Another asserting category")]
        [TestCase(5, 7, 12)]
        [TestCase(2, 6, 8)]
        [TestCase(1, 0, 1)]
        public void Add_A_To_B_Returns_R_UITest(int a, int b, int r)
        {
            Assert.IsTrue(a + b == r);
        }
    }
}
