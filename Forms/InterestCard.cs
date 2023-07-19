using System;
using Aquality.Selenium.Core.Utilities;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Web.Utils;

namespace Web.Forms
{
    public class InterestCard : Form
    {
        private ICheckBox unselectCheckBox => ElementFactory.GetCheckBox(By.XPath("//label[@for='interest_unselectall']"), "Unselect checkbox");
        private IButton nextButton => ElementFactory.GetButton(By.ClassName("button--stroked"), "Next button");
        private IButton uploadButton => ElementFactory.GetButton(By.ClassName("avatar-and-interests__upload-button"), "Next button");
        private IList<ICheckBox> interestCheckBoxes => ElementFactory.FindElements<ICheckBox>(By.XPath("//label[not (contains(@for,'select'))]"));

        private string imagePath = @"image.jpg";

        public InterestCard() : base(By.XPath("//div[@class='avatar-and-interests__form']"),"Interest card")
        {
        }

        public void ClickOnUnselectChexkBox()
        {
            unselectCheckBox.Check();
        }
        public void ClickRandomInterestCheckBoxes(int countOfCheBoxes)
        {
            var indexes = RandomForTests.RandonDifferentPositiveNumbers(countOfCheBoxes, RandomForTests.RandomInt(interestCheckBoxes.Count));
            foreach (int index in indexes)
            {
                interestCheckBoxes[index].Click();
            }
        }
        public void ClickOnNextButon()
        {
            nextButton.Click();
        }
    }
}