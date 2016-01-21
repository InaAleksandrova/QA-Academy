﻿namespace QAAcademyDemo.Telerik.Core.Pages_02.ShoppingCartPage
{
    using OpenQA.Selenium;
    using QAAcademyDemo.Telerik.Core.Pages_01;
    using QAAcademyDemo.Telerik.Core.Pages_01.ShoppingCartPage;
    using QAAcademyDemo.Telerik.Core.Pages_02;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ShoppingCartPage : BasePage
    {
        public ShoppingCartPage(IWebDriver driver) : base(driver)
        {
        }

        public void ChangeQuantity(int quantity)
        {
            ////this.Map.Quantity
        }

        public override void Navigate()
        {
            this.Driver.Navigate().GoToUrl("https://www.telerik.com/account/shopping-cart.aspx");
        }
    }
}