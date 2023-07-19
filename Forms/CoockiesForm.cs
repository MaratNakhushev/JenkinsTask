using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Web.Forms
{
    public class CoockiesForm : Form
    {
        private IButton acceptCookiesButton => ElementFactory.GetButton(By.ClassName("button--transparent"), "Accept cookies button");
        public CoockiesForm() : base(By.ClassName("class='cookies"), "Coockies form")
        {
        }
        public void ClickOnAcceptCookiesButton()
        {
            acceptCookiesButton.WaitAndClick();
        }
    }
}