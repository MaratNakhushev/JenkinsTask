using System;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Web.Forms
{
    public class Timer : Form
    {
        private ITextBox timer => ElementFactory.GetTextBox(By.ClassName("timer"), "Timer");
        public Timer() : base(By.ClassName("timer"), "Timer")
        {
        }
        public string GetTimeFromTimer()
        {
            return timer.GetText();
        }
    }
}



