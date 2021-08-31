using Ebay.Automation.Web.Pages;
using Ebay.Automation.Web.Pages.Fragments;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace Ebay.Test.Steps
{
    [Binding]
    public class AddItemToCardSteps : EbayBaseSteps
    {      
        public AddItemToCardSteps(FeatureContext context) : base(context)
        { 
        
        }        

        [When(@"I searched for (.*)")]
        public void ISearchedForItem(string item)
        {
            var homePage = new HomePage(AppDriver);
            homePage.SearchBarFragment.SetSearchText(item);
            homePage.SearchBarFragment.ClickSearch();
        }

        [When(@"I click on (.*) item")]
        public void IClickOnItemSpecified(int itemIndex)
        {
            var searchResultsPage = new SearchResultsPage(AppDriver);
            searchResultsPage.ClickOnItem(itemIndex);
        }

        [When(@"I add item in to the cart")]
        public void IAddItemInToTheCart()
        {
            var itemDetailsPage = new ItemDetailsPage(AppDriver);

            var itemTitle = itemDetailsPage.GetItemTitle();
            base.SetContextValue("ItemTitle",itemTitle);

            itemDetailsPage.ClickAddToCart();
            itemDetailsPage.ClickNoThanks();
        }

        [Then(@"I should see added item in the cart")]
        public void IShouldSeeAddedItemInCart()
        {
            var shoppingCartPage = new ShoppingCartPage(AppDriver);
            var result = shoppingCartPage.IsItemExists(base.GetContextValue<string>("ItemTitle"));
            Assert.True(result, "Item not found in the cart");
        }


        }
}
