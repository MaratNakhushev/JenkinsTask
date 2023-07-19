using System;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Web.Forms
{
    public class PersonalDetailCard : Form
    {
        public PersonalDetailCard() : base(By.ClassName("personal-details__form"), "Personal detail card")
        {
        }
    }
}