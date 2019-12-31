using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using UITest.Pages;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    public class Tests : BaseTestFixture
    {
        public Tests(Platform platform) : base(platform)
        {

        }

        [Test]
        [TestCase("Automated testing new item", "Automated testing description")]
        public void AddNewItem(string name, string description)
        {
            new ItemsPage()
                .AddNewItem();
            new NewItemPage()
                .EnterItemName(name)
                .EnterItemDescription(description)
                .Save();
            new ItemsPage()
                .FindItem(name);
            new ItemsPage()
                .FindItem(description);
        }

        [Test]
        public void Repl()
        {
            app.Repl();
        }
    }
}
