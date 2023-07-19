using System;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Web.Forms
{
    public class HelpForm : Form
    {
        private IButton hideButton => ElementFactory.GetButton(By.ClassName("help-form__send-to-bottom-button"), "Hide help form");
        public HelpForm() : base(By.ClassName("help-form__close-button"), "Help form")
        {
        }
        public void HideHelpForm()
        {
            hideButton.Click();
        }
    }
}