using System;
using Aquality.Selenium.Core.Forms;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Web.Forms.Pages
{
    public class MainPage : Form
    {
        public MainPage() : base(By.ClassName("logo__icon"), "Main page logo")
        {
        }
        private IButton nextPageeButton => ElementFactory.GetButton(By.ClassName("start__link"), "Next page link");

        public void ClickOnNextPageButton()
        {
            nextPageeButton.Click();
        }

    }
}