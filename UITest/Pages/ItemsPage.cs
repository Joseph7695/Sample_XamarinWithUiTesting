using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITest.Pages
{
    public class ItemsPage : BasePage
    {
        readonly Query itemsListView;
        //readonly Query firstItem;
        
        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("ItemsListView"),
            iOS = x => x.Marked("ItemsListView")
        };

        public ItemsPage()
        {
            itemsListView = x => x.Marked("ItemsListView");
        }

        public void SelectFirstItem()
        {
            app.WaitForElement(itemsListView);
            app.Tap(x => x.Marked("ItemsListView").Child());
        }

        public void AddNewItem()
        {
            app.Tap(x => x.Marked("Add"));
        }
        public  ItemsPage FindItem(string text)
        {
            app.ScrollDownTo(text);
            app.Flash(text);
            return this;
        }
        
    }
}
