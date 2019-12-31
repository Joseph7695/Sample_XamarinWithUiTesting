using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITest.Pages
{
    public class NewItemPage : BasePage
    {
        readonly Query itemNameEntry;
        readonly Query itemDescriptionEntry;
        readonly Query saveButton;
        readonly Query cancelButton;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("NewItemPage"),
            iOS = x => x.Marked("NewItemPage")
        };

        public NewItemPage()
        {
            itemNameEntry = x => x.Marked("NewItemPage.ItemName");
            itemDescriptionEntry = x => x.Marked("NewItemPage.ItemDescription");
            saveButton = x => x.Marked("Save");
            cancelButton = x => x.Marked("Cancel");
        }

        public NewItemPage EnterItemName(string itemName)
        {
            app.WaitForElement(itemNameEntry);
            app.ClearText(itemNameEntry);
            app.EnterText(itemNameEntry, itemName);
            app.Screenshot($"Item name \"{itemName}\" entered");
            return this;
        }
        public NewItemPage EnterItemDescription(string itemDescription)
        {
            app.WaitForElement(itemDescriptionEntry);
            app.ClearText(itemDescriptionEntry);
            app.EnterText(itemDescriptionEntry, itemDescription);
            app.Screenshot($"Item description, \"{itemDescription}\" entered");
            return this;
        }
        public void Save()
        {
            app.DismissKeyboard();
            app.WaitForElement(saveButton);
            app.Screenshot("NewItemPage - Saving");
            app.Tap(saveButton);
        }
        public void Cancel()
        {
            app.DismissKeyboard();
            app.WaitForElement(cancelButton);
            app.Screenshot("NewItemPage - Cancelling");
            app.Tap(cancelButton);
        }
    }
}
