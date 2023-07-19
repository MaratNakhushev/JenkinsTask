using System;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Web.Utils;

namespace Web.Forms.Pages
{
    public class LoginCard : Form
    {
        private ITextBox passwordField => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Choose Password']"), "Password field");
        private ITextBox emailField => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Your email']"), "Email field");
        private ITextBox domainField => ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Domain']"), "Domain field");
        private IButton nextButton => ElementFactory.GetButton(By.ClassName("button--secondary"), "Next page button");
        private IButton dropDownDomainOptionsButton => ElementFactory.GetButton(By.ClassName("dropdown__opener"), "Domain option dropdown");
        private ICheckBox termsCheckBox => ElementFactory.GetCheckBox(By.ClassName("checkbox__check"), "Terms & Conditions chekbox");
        private IList<IComboBox> domainOptions => ElementFactory.FindElements<IComboBox>(By.ClassName("dropdown__list-item"),"Domain options");

        private Random random = new Random();


        public LoginCard() : base(By.XPath("//div[@class='login-form__container']"), "Login card")
        {
        }
        public void FillPasswordField(string password)
        {
            passwordField.ClearAndType(password);
        }
        public void FillEmailField(string email)
        {
            emailField.ClearAndType(email);
        }

        public void FillDomainField(string domain)
        {
            domainField.ClearAndType(domain);
        }
        public void ClickOnDropDownDomainOptionsFlield()
        {
            dropDownDomainOptionsButton.Click();
        }
        public void ClickOnRandomDomainOption()
        {
            domainOptions[random.Next(domainOptions.Count)].WaitAndClick();
        }

        public void ClickOnTermsAndConditionsChekbox()
        {
            termsCheckBox.Click();
        }

        public void ClickOnNextButton()
        {
            nextButton.Click();
        }
    }
}